using Contracts;
using MassTransit;
using System.Threading.Tasks;

namespace UserService.Services
{
    public class RabbitMqPublisher : IRabbitMqPublisher
    {
        private readonly IBus _bus;

        public RabbitMqPublisher(IBus bus)
        {
            _bus = bus;
        }

        public async Task Publish(UserCreatedEvent message)
        {
            var queueName = "user-created-queue";

            await _bus.Publish<UserCreatedEvent>(message);
        }
    }
}
