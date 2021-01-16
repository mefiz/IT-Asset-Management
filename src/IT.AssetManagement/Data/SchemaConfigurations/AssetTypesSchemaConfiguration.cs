using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SchemaConfigurations
{
    public class AssetTypesSchemaConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(60);

            builder.HasIndex(i => i.Name).IsUnique();

            builder.HasData(
                new AssetType{Id = 1, Name="Monitor"},
                new AssetType{Id = 2, Name="CPU"},
                new AssetType{Id = 3, Name="Keyboard"},
                new AssetType{Id = 4, Name="Mouse"},
                new AssetType{Id = 5, Name="Printer"}
            );
        }
    }
}