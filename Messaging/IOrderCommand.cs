
namespace Messaging
{
    public interface IOrderCommand
    {
        int OrderId { get; set; }
        string OrderCode { get; set; }
    }
}
