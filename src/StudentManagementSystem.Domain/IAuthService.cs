// File: Domain/IAuthService.cs
namespace StudentManagementSystem.Domain
{
    public interface IAuthService
    {
        string? Authenticate(string username, string password);
        void RegisterUser(string username, string password, string email);
    }
}
