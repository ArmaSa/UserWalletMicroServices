using Contracts;

namespace WalletService.Consumers;

public class UserCreatedConsumer
{
    public void Handle(UserCreatedEvent user)
    {
        Console.WriteLine($"✅ WalletService: Received UserCreatedEvent:");
        Console.WriteLine($"   ➤ ID: {user.UserId}");
        Console.WriteLine($"   ➤ Name: {user.FullName}");
        Console.WriteLine($"   ➤ Email: {user.Email}");

        // اضافه کردن کیف پول
    }
}
