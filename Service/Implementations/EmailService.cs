using EmailNotificationSMTP.Service.Interfaces;
using System.Net;
using System.Net.Mail;

namespace EmailNotificationSMTP.Service.Implementations
{
    public class EmailService: IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var smtpClient = new SmtpClient(_config["EmailSettings:SmtpHost"])
            {
                Port = int.Parse(_config["EmailSettings:SmtpPort"]),
                Credentials = new NetworkCredential(
                    _config["EmailSettings:SenderEmail"],
                    _config["EmailSettings:SenderPassword"]
                ),
                EnableSsl = true
            };

            var mailMessage = new MailMessage(
                _config["EmailSettings:SenderEmail"], to, subject, body);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
    
}
