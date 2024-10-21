using System;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string School { get; set; }

        // Remove ICollection<Enrollment> - relationships handled via repositories
    }
}
