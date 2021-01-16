using Data.SchemaConfigurations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AssetManagementContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetHistory> AssetsHistory { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }


        public AssetManagementContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssetsSchemaConfiguration());
            modelBuilder.ApplyConfiguration(new AssetsHistorySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new AssetTypesSchemaConfiguration());
            modelBuilder.ApplyConfiguration(new StaffsSchemaConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentsSchemaConfiguration());
        }
    }
}