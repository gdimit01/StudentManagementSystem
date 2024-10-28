using System;
using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Models
{
    public class Department : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string DepartmentName { get; set; }
        public string HeadOfDepartment { get; set; }

        // Remove navigation properties as they are not used with Dapper
    }
}
