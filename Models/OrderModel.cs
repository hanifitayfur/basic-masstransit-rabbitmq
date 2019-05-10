using Messaging;

namespace Models
{
    public class OrderModel : IOrderCommand
    {
        public string OrderCode { get; set; }
        public int OrderId { get; set; }
    }
}
