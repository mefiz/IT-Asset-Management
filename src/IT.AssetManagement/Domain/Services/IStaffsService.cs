using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface IStaffsService
    {
        public Task<ICollection<Staff>> GetStaffsAsync();
        public Task<IEnumerable<Department>> GetDepartmentsAsync();
        public Task<Staff> SaveNewStaffAsync(Staff staff, Department department);
        public Task<Staff> GetStaffDetails(int id);
        public Task<ICollection<AssetHistory>> GetAssetHistoryAsync(Staff staff);
        public Task<AssetHistory> Unassign(AssetHistory history);
        public Task<string> GetCurrentAssignedStaff(Asset asset);
    }
}