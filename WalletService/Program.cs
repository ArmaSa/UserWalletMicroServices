using MassTransit;
using WalletService.Consumers;
using Contracts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddScoped<IEventConsumer<UserCreatedEvent>, UserCreatedEventHandler>();

        services.AddMassTransit(x =>
        {
            x.AddConsumer<UserCreatedConsumer>();

            x.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host(hostContext.Configuration["RabbitMQ:Host"], "/", h =>
                {
                    h.Username(hostContext.Configuration["RabbitMQ:Username"]);
                    h.Password(hostContext.Configuration["RabbitMQ:Password"]);
                });

                cfg.ReceiveEndpoint("user-created-queue", e =>
                {
                    e.ConfigureConsumer<UserCreatedConsumer>(ctx);
                });
            });
        });
    });

await builder.Build().RunAsync();
