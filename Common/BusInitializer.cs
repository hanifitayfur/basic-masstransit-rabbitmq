using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace Common
{
    public class BusInitializer
    {
        private static readonly Lazy<BusInitializer> _Instance = new Lazy<BusInitializer>(() => new BusInitializer());

        private BusInitializer()
        {
        }

        public static BusInitializer Instance => _Instance.Value;

        public IBusControl CreateBus(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(MqConstants.RabbitMQUri), hst =>
                 {
                     hst.Username(MqConstants.RabbitMQUserName);
                     hst.Password(MqConstants.RabbitMQPassword);
                 });

                registrationAction?.Invoke(cfg, host);
            });
        }
    }
}