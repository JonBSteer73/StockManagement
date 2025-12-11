using Microsoft.AspNetCore.Mvc;
using StockManagement.API.Models;
using StockManagement.DAL;

namespace StockManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        public StockController()
        {
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
