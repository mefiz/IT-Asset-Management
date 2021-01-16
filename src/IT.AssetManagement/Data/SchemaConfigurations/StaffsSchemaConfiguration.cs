using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SchemaConfigurations
{
    public class StaffsSchemaConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(k => k.Id);
            
            builder.Property(s => s.Name).IsRequired().HasMaxLength(120);
            builder.Property(s => s.NationalIdentificationNumber).HasColumnName("NID").HasMaxLength(7);
            builder.Property(s => s.StaffNumber).IsRequired().HasMaxLength(7);

            builder.HasIndex(s => s.NationalIdentificationNumber).IsUnique();
            builder.HasIndex(s => s.StaffNumber).IsUnique();

            builder.HasOne(s => s.Department).WithMany(d => d.Staffs).HasForeignKey(s => s.DepartmentId);

            builder.HasData(
                new Staff{Id=1, StaffNumber="A001", NationalIdentificationNumber="A123456", Name="Ahmed Mohamed", DepartmentId=1},
                new Staff{Id=2, StaffNumber="A002", NationalIdentificationNumber="A223422", Name="Hussain Ali", DepartmentId=1},
                new Staff{Id=3, StaffNumber="B003", NationalIdentificationNumber="A323433", Name="Fathimath Moosa Manik", DepartmentId=2},
                new Staff{Id=4, StaffNumber="A017", NationalIdentificationNumber="A423444", Name="Ibrahim Hussain", DepartmentId=2},
                new Staff{Id=5, StaffNumber="EE01", NationalIdentificationNumber="A523455", Name="Aishath Mariyam", DepartmentId=3},
                new Staff{Id=6, StaffNumber="AE001", NationalIdentificationNumber="A623466", Name="Hassan Ali Ibrahim", DepartmentId=3}
            );
        }
    }
}