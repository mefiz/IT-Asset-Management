using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class StaffsService : IStaffsService
    {
        private readonly AssetManagementContext _context;

        public StaffsService(AssetManagementContext context)
        {
            _context = context;
        }

        public async Task<ICollection<AssetHistory>> GetAssetHistoryAsync(Staff staff)
        {
            return await _context.AssetsHistory.AsNoTracking().Where(h => h.Staff == staff)
                .Include(h => h.Asset).AsNoTracking().Include(h => h.Asset.Type)
                .ToListAsync();
        }

        public async Task<string> GetCurrentAssignedStaff(Asset asset)
        {
            string staffName = null;


            AssetHistory history = await _context.AssetsHistory
            .Where(h => h.Asset == asset)
            .Include(h => h.Staff)
            .OrderByDescending(h => h.AssignedDate)
            .FirstOrDefaultAsync();

            if (history != null)
            {
                staffName = history.Staff.Name;
            }

            return staffName;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.AsNoTracking().Include(d => d.Staffs).ToListAsync();
        }

        public async Task<Staff> GetStaffDetails(int id)
        {
            Staff staff = null;
            staff = await _context.Staffs.AsNoTracking().Include(s => s.Department).Include(s => s.Assets).FirstOrDefaultAsync(s => s.Id == id);
            return staff;
        }

        public async Task<ICollection<Staff>> GetStaffsAsync()
        {
            return await _context.Staffs.AsNoTracking().Include(s => s.Department).OrderBy(s => s.Department.Name).ToListAsync();
        }

        public async Task<Staff> SaveNewStaffAsync(Staff staff, Department department)
        {
            staff.DepartmentId = department.Id;
            await _context.Staffs.AddAsync(staff);
            await _context.SaveChangesAsync();
            _context.Dispose();

            return staff;
        }

        public async Task<AssetHistory> Unassign(AssetHistory history)
        {
            var date = DateTime.Now;
            history.UnAssignedDate = date;
            _context.AssetsHistory.Update(history);

            Asset asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == history.Asset.Id);
            asset.Status = Enums.AssetStatus.NotAssigned;

            _context.Assets.Update(asset);

            await _context.SaveChangesAsync();
            _context.Dispose();

            return history;
        }
    }
}