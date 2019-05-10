using Common;
using MassTransit;
using System;

namespace ConsumerApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = BusInitializer.Instance.CreateBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, MqConstants.Queen, e =>
                {
                    e.Consumer<ConsumerApp.OrderCommandConsumerApp2>();
                });
            });

            bus.Start();

            Console.WriteLine("Listening consumer2");
            Console.ReadLine();
        }
    }
}
