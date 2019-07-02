using MediatR;
using Menyoo.OrderBasket.Domain.Commands;

namespace Menyoo.OrderBasket.Domain.Contracts.Commands
{
    public abstract class Command : IRequest<CommandResult>
    {
        public abstract bool IsValid();
    }
}