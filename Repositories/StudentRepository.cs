using System.Collections.Generic;
using System.Linq;
using Dapper;
using StudentManagementSystem.Models;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public StudentRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                return connection.Query<Student>("SELECT * FROM Students").ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                return connection.QuerySingleOrDefault<Student>("SELECT * FROM Students WHERE Id = @Id", new { Id = id });
            }
        }

        public void AddStudent(Student student)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                var sql = "INSERT INTO Students (FirstName, LastName, Age, School) VALUES (@FirstName, @LastName, @Age, @School)";
                connection.Execute(sql, student);
            }
        }

        public bool UpdateStudent(Student student)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                var sql = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Age = @Age, School = @School WHERE Id = @Id";
                var rowsAffected = connection.Execute(sql, student);
                return rowsAffected > 0;
            }
        }

        public bool DeleteStudent(int id)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                var sql = "DELETE FROM Students WHERE Id = @Id";
                var rowsAffected = connection.Execute(sql, new { Id = id });
                return rowsAffected > 0;
            }
        }
    }
}
