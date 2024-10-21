// File: Models/Teacher.cs
namespace StudentManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }  // Add this property if missing
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}
