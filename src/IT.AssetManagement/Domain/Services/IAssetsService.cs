using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface IAssetsService
    {
        public Task<String> GenerateAssetNumberAsync();
        public Task<IEnumerable<AssetType>> GetAssetTypesAsync();
        public Task<ICollection<Asset>> GetAssetsAsync();
        public Task<Asset> SaveNewAssetAsync(Asset asset, AssetType type, Staff assignedToStaff, string assignedDate);
        public Task<Asset> DiscardAssetAsync(Asset asset);
        public Task<AssetHistory> AssignAssetAsync(Asset asset, Staff staff);
    }
}