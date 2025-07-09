using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WalletService.Services;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((context, services) =>
{
    services.AddScoped<IEventConsumer<UserCreatedEvent>, UserCreatedConsumer>();
    services.AddHostedService<RabbitMqConsumer>();
});

await builder.Build().RunAsync();
