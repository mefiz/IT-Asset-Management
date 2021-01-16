using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SchemaConfigurations
{
    public class DepartmentsSchemaConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(d => d.Name).IsRequired().HasMaxLength(60);

            builder.HasIndex(i => i.Name).IsUnique();

            builder.HasData(
                new Department{Id=1, Name="Administration"},
                new Department{Id=2, Name="Accounts"},
                new Department{Id=3, Name="Human Resources"}
            );
        }
    }
}