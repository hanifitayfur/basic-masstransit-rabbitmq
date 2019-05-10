using MassTransit;
using Messaging;
using System;

namespace ConsumerApp
{
    public class OrderCommandConsumer : Consumes<IOrderCommand>.All
    {
        public void Consume(IOrderCommand message)
        {
            Console.Out.WriteLineAsync($"App1 -  OrderCode: {message.OrderCode} Id: {message.OrderId}");
        }
    }
}
