using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Models
{
    public class Administrator : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public User User { get; set; }
    }
}
