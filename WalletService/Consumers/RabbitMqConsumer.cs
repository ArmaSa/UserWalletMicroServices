using MassTransit;
using Contracts;

namespace WalletService.Consumers;

public class UserCreatedConsumer : IConsumer<UserCreatedEvent>
{
    private readonly ILogger<UserCreatedConsumer> _logger;
    private readonly IEventConsumer<UserCreatedEvent> _handler;

    public UserCreatedConsumer(
        ILogger<UserCreatedConsumer> logger,
        IEventConsumer<UserCreatedEvent> handler)
    {
        _logger = logger;
        _handler = handler;
    }

    public async Task Consume(ConsumeContext<UserCreatedEvent> context)
    {
        var @event = context.Message;
        _logger.LogInformation($"User created: {@event.FullName}");

        await _handler.HandleAsync(@event);
    }
}