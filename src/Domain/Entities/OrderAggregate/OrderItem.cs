namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem() {}
        public OrderItem (ProductItemOrdered
        itemOrdered, decimal price, int quantity)
        {
            itemOrdered = itemOrdered;
            Price = price;
            Quantity = quantity;
        }

        public ProductItemmOrdered ItemOrdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }   
}