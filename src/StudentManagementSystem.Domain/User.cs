namespace StudentManagementSystem.Models
{
    public class User
    {
        public int? UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }

        public int? TeacherId { get; set; }
        public int? StudentId { get; set; }

        // Navigation properties
        public Teacher? Teacher { get; set; }
        public Student? Student { get; set; }
    }
}  
