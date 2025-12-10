using Microsoft.AspNetCore.Mvc;
using StockManagement.API.Models;
using StockManagement.DAL;

namespace StockManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly StockDbContext dbContext;

        public StockController(StockDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("list")]
        public async Task<IEnumerable<InventoryItemModel>> GetAllStock()
        {
            return new List<InventoryItemModel>
            {
                new InventoryItemModel { Id = Guid.NewGuid() },
                new InventoryItemModel { Id = Guid.NewGuid() }
            };
        }

    }
}
