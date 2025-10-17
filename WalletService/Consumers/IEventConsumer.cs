namespace WalletService.Consumers
{
    public interface IEventConsumer<T>
    {
        Task HandleAsync(T @event);
    }
}
