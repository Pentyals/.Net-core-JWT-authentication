namespace JWT_authentication_.dotnet_core_demo.Services
{
    public interface IUserService
    {
        bool ValidateUser(string username, string password);
    }
}
