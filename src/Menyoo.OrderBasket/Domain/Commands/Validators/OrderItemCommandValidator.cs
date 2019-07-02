using FluentValidation;

namespace Menyoo.OrderBasket.Domain.Commands.Validators
{
    public class OrderItemCommandValidator : AbstractValidator<OrderItemCommand>
    {
        public OrderItemCommandValidator()
        {
            RuleFor(command => command.ProductId).NotEmpty();
            RuleFor(command => command.Quantity).GreaterThan(0);
        }
    }
}
