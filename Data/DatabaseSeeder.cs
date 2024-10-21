using StudentManagementSystem.Data;
using System.Data;
using Dapper;

namespace StudentManagementSystem.Data
{
    public class DatabaseSeeder
    {
        private readonly DatabaseConnection _dbConnection;

        public DatabaseSeeder(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Seed()
        {
            using (IDbConnection connection = _dbConnection.CreateConnection())
            {
                // Example: Insert initial data into the Students table
                var sql = @"
                    INSERT INTO Students (FirstName, LastName, Age, School)
                    VALUES ('James', 'Smith', 20, 'Computer Science')";
                connection.Execute(sql);
                
                // Add more seeding logic as needed for other tables...
            }
        }
    }
}
