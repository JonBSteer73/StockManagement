namespace StockManagement.API.Models
{
    public class InventoryItemModel
    {
        public Guid Id { get; set; }
        public string ItemDescription { get; set; } = default!;
        public string ProductTypeName { get; set; } = default!;
        public int QuantityInStock { get; set; }
        public bool IsPerishable { get; set; }
    }
}
