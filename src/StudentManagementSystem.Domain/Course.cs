using System;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public int? Credits { get; set; }
        public int? DepartmentId { get; set; }

        // Remove ICollection<Enrollment> as it's not used with Dapper
        // Fetch related entities manually in repositories when needed
    }
}
