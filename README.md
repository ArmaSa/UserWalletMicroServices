# 🧱 Microservices with RabbitMQ (.NET 8)

این پروژه شامل دو میکروسرویس ساده است که با RabbitMQ با هم ارتباط برقرار می‌کنند.

---

## 🔧 ساختار سرویس‌ها

- `UserService`: ثبت کاربر جدید و ارسال پیام به RabbitMQ
- `WalletService`: مصرف پیام و ساخت کیف پول

---

## 🧪 نحوه اجرا

### ✅ روش 1: اجرای کامل با Docker Compose

برای اجرای هم‌زمان RabbitMQ، UserService و WalletService با Docker:

docker-compose up --build


## ✅ روش 2: اجرای هر کدام از پروژه ها به صورت جداگانه و RabbitMQ

برای اجرای جداگانه RabbitMQ، UserService و WalletService با Docker:


docker run -d --hostname rabbit --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management

cd WalletService
dotnet run

cd UserService
dotnet run

