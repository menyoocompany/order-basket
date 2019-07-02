using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Menyoo.OrderBasket.Domain.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }

        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public OrderStatus Status { get; private set; }
        
        public IReadOnlyCollection<OrderItem> Items => _items.ToImmutableList();

        public void AddItem(Product product, int quantity) => _items.Add(new OrderItem(product, quantity));

        public void AddItems(IEnumerable<(Product product, int quantity)> products)
        {
            foreach (var (product, quantity) in products)
            {
                _items.Add(new OrderItem(product, quantity));
            }
        }

        public void AddItems(IEnumerable<OrderItem> items)
        {
            foreach (var item in items)
            {
                _items.Add(item);
            }
        }
    }
}
