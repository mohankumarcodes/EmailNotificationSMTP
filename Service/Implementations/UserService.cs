using EmailNotificationSMTP.Data;
using EmailNotificationSMTP.Models;
using EmailNotificationSMTP.Service.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace EmailNotificationSMTP.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IEmailService _emailService;
        private readonly AppDbContext _dbContext;

        public UserService(IEmailService emailService, AppDbContext dbContext)
        {
            _emailService = emailService;
            _dbContext = dbContext;
        }

        public async Task<string> CreateUserAsync(string email)
        {
            var user=new User { Email = email };

            _dbContext.Add(user);
            
            await _dbContext.SaveChangesAsync();

            await _emailService.SendEmailAsync(email, "Message From EmailNotificationSMTP APP Asp.Net Core", "Thank you for registering!  Email Notification SMTP working Fine...............");//Controller->Interface->Service->implementation

            return "User created and email sent";
        }
    }
}
