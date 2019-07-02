using MediatR;
using Menyoo.OrderBasket.Domain.Commands;
using Menyoo.OrderBasket.Domain.Contracts.Commands;

namespace Menyoo.OrderBasket.Domain.Contracts.Handlers.Commands
{
    public interface ICreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CommandResult> { }
}
