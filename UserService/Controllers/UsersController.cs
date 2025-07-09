using Contracts;
using Microsoft.AspNetCore.Mvc;
using UserService.Services;

namespace UserService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IRabbitMqPublisher _publisher;

    public UsersController(IRabbitMqPublisher publisher)
    {
        _publisher = publisher;
    }

    [HttpPost]
    public IActionResult Create()
    {
        var user = new UserCreatedEvent
        {
            UserId = Guid.NewGuid().ToString(),
            FullName = "Ali Rezaei",
            Email = "ali@example.com"
        };

        _publisher.Publish(user);
        return Ok("User created & event published.");
    }
}
