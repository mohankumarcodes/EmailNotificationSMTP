namespace EmailNotificationSMTP.Service.Interfaces
{
    public interface IUserService
    {
        Task<string> CreateUserAsync(string email);//Controller->Interface->Service->implementation
    }
}
