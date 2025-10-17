using Contracts;
using WalletService.Consumers;

public class UserCreatedEventHandler : IEventConsumer<UserCreatedEvent>
{
    private readonly ILogger<UserCreatedEventHandler> _logger;

    public UserCreatedEventHandler(ILogger<UserCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task HandleAsync(UserCreatedEvent @event)
    {
        _logger.LogInformation($"[Handler] Processing user wallet: {@event.FullName}");
        return Task.CompletedTask;
    }
}
