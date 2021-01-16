using System;
using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string AssetNumber { get; set; }
        public AssetStatus Status { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime? DiscardedDate { get; set; }
        public DateTime? LastAssignedDate { get; set; }


        public int TypeId { get; set; }
        public virtual AssetType Type { get; set; }
        public virtual IEnumerable<AssetHistory> History { get; set; }
    }
}