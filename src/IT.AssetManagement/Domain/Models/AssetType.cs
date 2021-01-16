using System.Collections.Generic;

namespace Domain.Models
{
    public class AssetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public IEnumerable<Asset> Assets { get; set; }
    }
}