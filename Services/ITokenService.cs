namespace JWT_authentication_.dotnet_core_demo.Services
{
    public interface ITokenService
    {
        string BuildToken(string username);
    }
}
