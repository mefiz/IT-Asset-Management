using System;

namespace Domain.Models
{
    public class AssetHistory
    {
        public int Id { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? UnAssignedDate { get; set; }

        public int AssetId { get; set; }
        public virtual Asset Asset { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}