namespace Menyoo.OrderBasket.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Total = Product.Price * Quantity;
        }

        public Product Product { get; }
        public int Quantity { get; }
        public decimal Total { get; }
    }
}
