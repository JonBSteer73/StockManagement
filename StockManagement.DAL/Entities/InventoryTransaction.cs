using StockManagement.DAL.Enums;

namespace StockManagement.DAL.Entities
{
    public class InventoryTransaction
    {
        public Guid Id { get; set; }
        public Guid InventoryItemId { get; set; }
        public InventoryItem InventoryItem { get; set; } = default!;
        public int QuantityChanged { get; set; }
        public DateTime TransactionDate { get; set; }
        public StockTransactionType TransactionType { get; set; }

    }
}
