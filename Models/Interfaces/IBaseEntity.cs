namespace StudentManagementSystem.Models.Interfaces;

public interface IBaseEntity
{
    int Id { get; set; }
    bool IsDeleted { get; set; }
}