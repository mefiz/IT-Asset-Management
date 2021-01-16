using System.Collections.Generic;

namespace Domain.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string StaffNumber { get; set; }
        public string NationalIdentificationNumber { get; set; }
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual IEnumerable<AssetHistory> Assets { get; set; }
    }
}