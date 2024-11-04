using StudentManagementSystem.Data;
using StudentManagementSystem.Domain;
using System.Collections.Generic;
using System.Data;
using Dapper;
using StudentManagementSystem.Models;



namespace StudentManagementSystem.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public TeacherRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                string sql = "SELECT * FROM Teachers";
                return connection.Query<Teacher>(sql);
            }
        }

        public Teacher GetTeacherById(int teacherId)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                string sql = "SELECT * FROM Teachers WHERE TeacherId = @TeacherId";
                return connection.QuerySingleOrDefault<Teacher>(sql, new { TeacherId = teacherId });
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                string sql = "INSERT INTO Teachers (FirstName, LastName, Email, DepartmentId) " +
                             "VALUES (@FirstName, @LastName, @Email, @DepartmentId)";
                connection.Execute(sql, teacher);
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                string sql = "UPDATE Teachers SET FirstName = @FirstName, LastName = @LastName, " +
                             "Email = @Email, DepartmentId = @DepartmentId WHERE TeacherId = @TeacherId";
                connection.Execute(sql, teacher);
            }
        }

        public void DeleteTeacher(int teacherId)
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                string sql = "DELETE FROM Teachers WHERE TeacherId = @TeacherId";
                connection.Execute(sql, new { TeacherId = teacherId });
            }
        }
    }
}
