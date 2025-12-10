using Microsoft.EntityFrameworkCore;
using StockManagement.DAL.Entities;

namespace StockManagement.DAL
{
    public class StockDbContext : DbContext
    {
        public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();
        public DbSet<ProductType> ProductTypes => Set<ProductType>();
        public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Quantity).IsRequired();
                entity.HasOne(e => e.ProductType)
                      .WithMany(pt => pt.InventoryItems)
                      .HasForeignKey(e => e.ProductTypeId);
            });
            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.HasOne(e => e.InventoryItem)
                      .WithMany(i => i.InventoryTransactions)
                      .HasForeignKey(e => e.InventoryItemId);
            });
        }
    }
}
