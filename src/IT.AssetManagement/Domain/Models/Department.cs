using System.Collections.Generic;

namespace Domain.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Staff> Staffs { get; set; }
    }
}