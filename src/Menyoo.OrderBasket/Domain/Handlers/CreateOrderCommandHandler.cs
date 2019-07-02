using Menyoo.OrderBasket.Domain.Commands;
using Menyoo.OrderBasket.Domain.Contracts.Handlers.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;
using Menyoo.OrderBasket.Domain.Contracts.Commands;

namespace Menyoo.OrderBasket.Domain.Handlers
{
    public class CreateOrderCommandHandler : ICreateOrderCommandHandler
    {
        public Task<CommandResult> Handle(CreateOrderCommand request, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    }
}
