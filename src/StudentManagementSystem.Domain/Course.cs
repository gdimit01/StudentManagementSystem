using System;
using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Models
{
    public class Course : IBaseEntity
    {
<<<<<<< HEAD:src/StudentManagementSystem.Domain/Course.cs
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public int? Credits { get; set; }
        public int? DepartmentId { get; set; }
=======
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
>>>>>>> master:Models/Course.cs

        // Remove ICollection<Enrollment> as it's not used with Dapper
        // Fetch related entities manually in repositories when needed
    }
}
