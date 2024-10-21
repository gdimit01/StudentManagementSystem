using System;

namespace StudentManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string HeadOfDepartment { get; set; }

        // Remove navigation properties as they are not used with Dapper
    }
}
