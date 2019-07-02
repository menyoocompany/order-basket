using FluentValidation;

namespace Menyoo.OrderBasket.Domain.Commands.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(command => command.Customer).NotEmpty();
            RuleForEach(command => command.Items).SetValidator(new OrderItemCommandValidator());
        }
    }
}
