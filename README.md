# EmailNotificationSMTP
This Repo contain Email Notification from sender to receiver mail with content using ASP.Net Core Wep API, Repository pattern, Abstraction, Dependency Injection, Services , Controllers.
# 📧 EmailNotificationSMTP

**EmailNotificationSMTP** is a simple ASP.NET Core Web API that demonstrates how to send transactional emails using the built-in `SmtpClient` and Gmail SMTP. It serves as a lightweight email microservice and is ideal for learning, integrating, or extending into larger systems.

---

## 🚀 Features

- ✅ ASP.NET Core Web API (.NET 6/7/8 compatible)
- ✅ Send emails via Gmail SMTP (`smtp.gmail.com`)
- ✅ Clean architecture (Controller → Interface → Implementation)
- ✅ Swagger UI support for easy testing
- ✅ Config-based SMTP setup using `appsettings.json`
- ✅ Supports Dependency Injection
- ✅ Easily extendable with database (EF Core ready)

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SMTP (`System.Net.Mail`)
- Swagger / Swashbuckle
- .NET Dependency Injection
- Visual Studio / VS Code
- Git & GitHub

---

---

## 🔐 Gmail SMTP Setup (Required)

To make Gmail SMTP work securely:

1. Enable **2-Step Verification** on your Gmail:  
   [https://myaccount.google.com/security](https://myaccount.google.com/security)

2. Generate an **App Password**:  
   [https://myaccount.google.com/apppasswords](https://myaccount.google.com/apppasswords)

3. Use that app password in your `appsettings.json`:

```json
"EmailSettings": {
  "SmtpHost": "smtp.gmail.com",
  "SmtpPort": 587,
  "SenderEmail": "your_email@gmail.com",
  "SenderPassword": "your_app_password"
}

To Run Locally :
git clone https://github.com/mohankumarcodes/EmailNotificationSMTP.git
cd EmailNotificationSMTP
dotnet restore
dotnet run

