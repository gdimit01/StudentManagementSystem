using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace StudentManagementSystem.Data
{
    public class DatabaseConnection
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DatabaseConnection(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _connectionString = _configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        public IDbConnection CreateConnection()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                throw new InvalidOperationException("Connection string is not valid.");
            }

            return new SqlConnection(_connectionString);
        }
    }
}
