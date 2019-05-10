using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Common;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISendEndpoint _bus;

        public OrderController()
        {
            var sendToUri = new Uri($"{MqConstants.RabbitMQUri}{MqConstants.Queen}");

            _bus = BusInitializer.Instance.CreateBus().GetSendEndpoint(sendToUri).Result;
        }

        [HttpPost]
        public void Post([FromBody] OrderModel orderModel)
        {
            _bus.Send(orderModel).Wait();
        }
    }
}