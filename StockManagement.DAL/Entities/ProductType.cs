namespace StockManagement.DAL.Entities
{
    public class ProductType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public bool IsPerishable { get; set; }
        public ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
    }
}
