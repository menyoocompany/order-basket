using System.Collections.Generic;
using Menyoo.OrderBasket.Domain.Commands.Validators;
using Menyoo.OrderBasket.Domain.Contracts.Commands;

namespace Menyoo.OrderBasket.Domain.Commands
{
    public class CreateOrderCommand : Command
    {
        public CreateOrderCommand() => Items = new List<OrderItemCommand>();

        public string Customer { get; set; }

        public IList<OrderItemCommand> Items { get; set; }

        public override bool IsValid()
        {
            var result = new CreateOrderCommandValidator().Validate(this);
            return result.IsValid;
        }
    }
}
