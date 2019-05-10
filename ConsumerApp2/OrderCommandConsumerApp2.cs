using MassTransit;
using Messaging;
using System;

namespace ConsumerApp
{
    public class OrderCommandConsumerApp2 : Consumes<IOrderCommand>.All
    {
        public void Consume(IOrderCommand message)
        {
            Console.Out.WriteLineAsync($"App2 - OrderCode: {message.OrderCode} Id: {message.OrderId}");
        }
    }
}
