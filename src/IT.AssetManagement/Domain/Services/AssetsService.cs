using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class AssetsService : IAssetsService
    {
        private readonly AssetManagementContext _context;

        public AssetsService(AssetManagementContext context)
        {
            _context = context;
        }

        public async Task<Asset> SaveNewAssetAsync(Asset asset, AssetType type, Staff assignedToStaff, string assignedDate)
        {
            asset.TypeId = type.Id;
            await _context.Assets.AddAsync(asset);
            await _context.SaveChangesAsync();

            //todo: add validation for type and staff
            if (asset.Status == AssetStatus.Assigned)
            {
                var history = new AssetHistory
                {
                    AssignedDate = DateTime.Parse(assignedDate),
                    AssetId = asset.Id,
                    StaffId = assignedToStaff.Id
                };

                asset.LastAssignedDate = DateTime.Parse(assignedDate);

                await _context.AssetsHistory.AddAsync(history);
                await _context.SaveChangesAsync();
            }

            return asset;
        }

        //Generates an asset number using the current date and the number of assets added today.
        //This is converted to a hexadecimal string
        public async Task<string> GenerateAssetNumberAsync()
        {
            var date = DateTime.Today;
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;

            var today = new DateTime(year, month, day);

            int count = await _context.Assets.Where(b => b.PurchasedDate.Date == today).CountAsync();
            count = count + 1;


            var code = Int32.Parse(year.ToString().Substring(Math.Max(0, year.ToString().Length - 4)) + month.ToString() + day.ToString() + count);
            var assetNumber = code.ToString("X");

            return assetNumber;
        }

        public async Task<ICollection<Asset>> GetAssetsAsync()
        {
            return await _context.Assets.AsNoTracking().OrderByDescending(x => x.PurchasedDate).Include(a => a.Type).ToListAsync();
        }

        public async Task<IEnumerable<AssetType>> GetAssetTypesAsync()
        {
            return await _context.AssetTypes.AsNoTracking().ToListAsync();
        }

        public async Task<Asset> DiscardAssetAsync(Asset asset)
        {   
            var discardedDate = DateTime.Now;
            asset.DiscardedDate = discardedDate;
            asset.Status = AssetStatus.Discarded;
            _context.Assets.Update(asset);

            AssetHistory history = await _context.AssetsHistory.Where(a => a.Asset == asset).Where(a => a.UnAssignedDate == null).FirstOrDefaultAsync();

            if (history != null) {
                history.UnAssignedDate = discardedDate;
                _context.AssetsHistory.Update(history);
            }
            
            await _context.SaveChangesAsync();
            _context.Dispose();

            return asset;
        }

        public async Task<AssetHistory> AssignAssetAsync(Asset asset, Staff staff)
        {
            var history = new AssetHistory
                {
                    AssignedDate = DateTime.Now,
                    AssetId = asset.Id,
                    StaffId = staff.Id
                };

            await _context.AssetsHistory.AddAsync(history);

            asset.LastAssignedDate = DateTime.Now;
            _context.Assets.Update(asset);

            await _context.SaveChangesAsync();
            _context.Dispose();

            return history;
        }
    }
}