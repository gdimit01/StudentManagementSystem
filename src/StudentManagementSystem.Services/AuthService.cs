using System.Collections.Generic;  // For Dictionary
using StudentManagementSystem.Domain;

namespace StudentManagementSystem.Services
{
    public class AuthService : IAuthService
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "testuser", "password123" }
        };

        public string? Authenticate(string username, string password)
        {
            if (_users.TryGetValue(username, out var storedPassword) && storedPassword == password)
            {
                return "sample-jwt-token"; // Replace with actual JWT generation
            }
            return null;
        }

        public void RegisterUser(string username, string password, string email)
        {
            _users[username] = password;
        }
    }
}
