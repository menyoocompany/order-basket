using MediatR;
using Menyoo.OrderBasket.Domain.Contracts.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace Menyoo.OrderBasket.Domain.Handlers.Behaviors
{
    public class FailFastValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
    where TRequest : Command
    where TResponse : CommandResult
    {
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next) =>
            request.IsValid() ? next() : Task.FromResult(new CommandResult { Success = false } as TResponse);
    }
}
