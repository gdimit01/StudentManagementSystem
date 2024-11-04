namespace StudentManagementSystem.Models
{
    public class Administrator
    {
        public int? AdminId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? UserId { get; set; }

        // Navigation properties
        public User? User { get; set; }
    }
}
