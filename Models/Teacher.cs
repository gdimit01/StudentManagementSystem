// File: Models/Teacher.cs

using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Models
{
    public class Teacher : IBaseEntity
    {
        public int Id { get; set; }  // Add this property if missing
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}
