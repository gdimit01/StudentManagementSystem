// File: StudentManagementSystem.Domain/ITeacherRepository.cs
using System.Collections.Generic;
using StudentManagementSystem.Models; // Ensure this is correct
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Domain
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int teacherId);
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
    }
}
