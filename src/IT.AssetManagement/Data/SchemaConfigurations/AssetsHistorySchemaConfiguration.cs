using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SchemaConfigurations
{
    public class AssetsHistorySchemaConfiguration : IEntityTypeConfiguration<AssetHistory>
    {
        public void Configure(EntityTypeBuilder<AssetHistory> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(ah => ah.AssignedDate).IsRequired();

            builder.HasOne(ah => ah.Staff).WithMany(s => s.Assets).HasForeignKey(ah => ah.StaffId);
            builder.HasOne(ah => ah.Asset).WithMany(a => a.History).HasForeignKey(ah => ah.AssetId);
        
            builder.HasData(
                new AssetHistory{Id=1, AssignedDate=DateTime.Parse("2021-01-15 14:00"), AssetId=6, StaffId=2},
                new AssetHistory{Id=2, AssignedDate=DateTime.Parse("2021-01-15 14:00"), AssetId=7, StaffId=2},
                new AssetHistory{Id=3, AssignedDate=DateTime.Parse("2021-01-15 14:00"), AssetId=8, StaffId=2},
                new AssetHistory{Id=4, AssignedDate=DateTime.Parse("2021-01-15 14:00"), AssetId=9, StaffId=2}
            );
        }
    }
}