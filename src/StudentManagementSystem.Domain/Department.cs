using System;
using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Models
{
    public class Department : IBaseEntity
    {
<<<<<<< HEAD:src/StudentManagementSystem.Domain/Department.cs
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? HeadOfDepartment { get; set; }
=======
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string DepartmentName { get; set; }
        public string HeadOfDepartment { get; set; }
>>>>>>> master:Models/Department.cs

        // Remove navigation properties as they are not used with Dapper
    }
}
