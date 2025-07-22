
public class UserService
{
    public bool ValidateUser(string username, string password)
    {
        return username == "admin" && password == "password";
    }
}
