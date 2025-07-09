using Contracts;

namespace WalletService.Consumers;

public class UserCreatedConsumer : IEventConsumer<UserCreatedEvent>
{
    private readonly ILogger<UserCreatedConsumer> _logger;

    public UserCreatedConsumer(ILogger<UserCreatedConsumer> logger)
    {
        _logger = logger;
    }

    public Task HandleAsync(UserCreatedEvent @event)
    {
        _logger.LogInformation($"User created: {@event.FirstName} {@event.LastName}");
        // Do something with the user...
        return Task.CompletedTask;
    }
}

