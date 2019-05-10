using Common;
using MassTransit;
using System;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = BusInitializer.Instance.CreateBus((cfg, host) =>
                {
                    cfg.ReceiveEndpoint(host, MqConstants.Queen, e =>
                    {
                        e.Consumer<OrderCommandConsumer>();
                    });
                });

            bus.Start();

            Console.WriteLine("Listening consumer1");
            Console.ReadLine();
        }
    }
}
