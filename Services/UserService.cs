
using JWT_authentication_.dotnet_core_demo.Services;

public class UserService: IUserService
{
    public bool ValidateUser(string username, string password)
    {
        return username == "admin" && password == "password";
    }
}
