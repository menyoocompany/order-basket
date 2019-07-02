using MediatR;
using Menyoo.OrderBasket.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Menyoo.OrderBasket.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrdersController(IMediator mediator) { _mediator = mediator; }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Success ? (IActionResult) Created("", result.Data) : BadRequest();
        }
    }
}
