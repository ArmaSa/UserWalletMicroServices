using Contracts;

namespace UserService.Services;

public interface IRabbitMqPublisher
{
    void Publish(UserCreatedEvent message);
}
