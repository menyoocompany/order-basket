namespace Menyoo.OrderBasket.Domain.Contracts.Commands
{
    public class CommandResult
    {
        public bool Success { get; set; }
        public object Data { get; set; }
    }
}