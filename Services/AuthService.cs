using StudentManagementSystem.DTOs;
using System.Collections.Generic;

namespace StudentManagementSystem.Services
{
    public class AuthService
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "testuser", "password123" }
        };

        public string? Authenticate(string username, string password)
        {
            // Simple authentication logic
            if (_users.TryGetValue(username, out var storedPassword) && storedPassword == password)
            {
                // In a real scenario, you'd generate and return a JWT token here
                return "sample-jwt-token";
            }

            return null;
        }

        public void RegisterUser(string username, string password, string email)
        {
            // Registration logic, such as storing the user in the database
            // For example purposes, adding to the dictionary
            _users[username] = password;
        }
    }
}
