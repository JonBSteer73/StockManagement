namespace StockManagement.DAL.Entities
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = default!;
        public int Quantity { get; set; }
        public Guid ProductTypeId { get; set; }
        public ProductType ProductType { get; set; } = default!;
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    }
}
