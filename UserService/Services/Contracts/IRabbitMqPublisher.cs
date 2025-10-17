using Contracts;

namespace UserService.Services;

public interface IRabbitMqPublisher
{
    Task Publish(UserCreatedEvent message);
}
