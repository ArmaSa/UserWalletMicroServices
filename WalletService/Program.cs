using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WalletService.Services;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((context, services) =>
{
    services.AddHostedService<RabbitMqConsumer>();
});

await builder.Build().RunAsync();
