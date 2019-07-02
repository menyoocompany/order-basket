namespace Menyoo.OrderBasket.Domain.Commands
{
    public class OrderItemCommand
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
