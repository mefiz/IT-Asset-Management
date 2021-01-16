using System;
using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SchemaConfigurations
{
    public class AssetsSchemaConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(a => a.AssetNumber).IsRequired().HasMaxLength(7);
            builder.Property(a => a.PurchasedDate).IsRequired();

            builder.HasIndex(a => a.AssetNumber).IsUnique();

            builder.HasOne(a => a.Type).WithMany(t => t.Assets).HasForeignKey(a => a.TypeId);

            builder.HasData(
                new Asset { Id = 1, AssetNumber = "C8619B9", Status = AssetStatus.NotAssigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 1 },
                new Asset { Id = 2, AssetNumber = "C8619BA", Status = AssetStatus.NotAssigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 2 },
                new Asset { Id = 3, AssetNumber = "C8619BB", Status = AssetStatus.NotAssigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 3 },
                new Asset { Id = 4, AssetNumber = "C8619BC", Status = AssetStatus.NotAssigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 4 },
                new Asset { Id = 5, AssetNumber = "C8619BD", Status = AssetStatus.NotAssigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 5 },

                new Asset { Id = 6, AssetNumber = "C8619C2", Status = AssetStatus.Assigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), LastAssignedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 1 },
                new Asset { Id = 7, AssetNumber = "C8619C3", Status = AssetStatus.Assigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), LastAssignedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 2 },
                new Asset { Id = 8, AssetNumber = "C8619C4", Status = AssetStatus.Assigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), LastAssignedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 3 },
                new Asset { Id = 9, AssetNumber = "C8619C5", Status = AssetStatus.Assigned, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), LastAssignedDate = DateTime.Parse("2021-01-15 14:00"), TypeId = 4 },

                new Asset { Id = 10, AssetNumber = "C861A26", Status = AssetStatus.Discarded, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), DiscardedDate = DateTime.Parse("2021-01-20 14:15"), TypeId = 1 },
                new Asset { Id = 11, AssetNumber = "C861A27", Status = AssetStatus.Discarded, PurchasedDate = DateTime.Parse("2021-01-15 14:00"), DiscardedDate = DateTime.Parse("2021-01-20 14:15"), TypeId = 2 }
            );
        }
    }
}