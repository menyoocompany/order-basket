namespace Menyoo.OrderBasket.Domain.Entities
{
    public class Product
    {
        public Product(string title, string image, decimal price, decimal quantity)
        {
            this.Title = title;
            this.Price = price;
            this.QuantityOnHand = quantity;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public decimal QuantityOnHand { get; private set; }

        public override string ToString()
        {
            return Title;
        }
    }
}