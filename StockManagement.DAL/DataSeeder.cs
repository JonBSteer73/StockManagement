using Microsoft.EntityFrameworkCore;
using StockManagement.DAL.Entities;

namespace StockManagement.DAL
{
    public class DataSeeder
    {
        private readonly StockDbContext _dbContext;

        public DataSeeder(StockDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task SeedDataAsync()
        {
            if (!await _dbContext.InventoryItems.AnyAsync())
            {
                _dbContext.ProductTypes.AddRange(
                    new ProductType
                    {
                        Id = Guid.Parse("bb6e0ef6-2ddd-4ec3-96a3-63028d3e2297"),
                        Name = "Electronics",
                        IsPerishable = false
                    },
                    new ProductType
                    {
                        Id = Guid.Parse("25836bc4-9562-40d6-a2a8-aa4b65c8a562"),
                        Name = "Books",
                        IsPerishable = false
                    },
                    new ProductType
                    {
                        Id = Guid.Parse("28824b38-1c77-406d-952e-d626681cafd2"),
                        Name = "Building Supplies",
                        IsPerishable = false
                    },
                    new ProductType
                    {
                        Id = Guid.Parse("8cd36321-3d81-42b3-99a8-d4ee49188e2d"),
                        Name = "Fruit & Vegetables",
                        IsPerishable = true
                    },
                    new ProductType
                    {
                        Id = Guid.Parse("4ed0fbc3-bbd0-40e2-ac44-a016f4b29047"),
                        Name = "Meat",
                        IsPerishable = true
                    }
                );

                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "128GB USB drive",
                        ProductTypeId = Guid.Parse("bb6e0ef6-2ddd-4ec3-96a3-63028d3e2297"),
                        Quantity = 50
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Wireless Keyboard",
                        ProductTypeId = Guid.Parse("bb6e0ef6-2ddd-4ec3-96a3-63028d3e2297"),
                        Quantity = 20
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Rick Astley: An Autobiography",
                        ProductTypeId = Guid.Parse("25836bc4-9562-40d6-a2a8-aa4b65c8a562"),
                        Quantity = 200
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Cement 20kg bag",
                        ProductTypeId = Guid.Parse("28824b38-1c77-406d-952e-d626681cafd2"),
                        Quantity = 80
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Nails 200 pack",
                        ProductTypeId = Guid.Parse("28824b38-1c77-406d-952e-d626681cafd2"),
                        Quantity = 150
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Cabbage",
                        ProductTypeId = Guid.Parse("8cd36321-3d81-42b3-99a8-d4ee49188e2d"),
                        Quantity = 80
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Lemon",
                        ProductTypeId = Guid.Parse("8cd36321-3d81-42b3-99a8-d4ee49188e2d"),
                        Quantity = 100
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Whole chicken",
                        ProductTypeId = Guid.Parse("4ed0fbc3-bbd0-40e2-ac44-a016f4b29047"),
                        Quantity = 30
                    });
                _dbContext.InventoryItems.AddRange(
                    new InventoryItem()
                    {
                        Id = Guid.NewGuid(),
                        Description = "Sirloin Steak 12oz",
                        ProductTypeId = Guid.Parse("4ed0fbc3-bbd0-40e2-ac44-a016f4b29047"),
                        Quantity = 45
                    });

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
