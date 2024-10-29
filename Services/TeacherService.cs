// File: Services/TeacherService.cs
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using System.Collections.Generic;

namespace StudentManagementSystem.Services
{
    public class TeacherService
    {
        private readonly IGenericRepository<Teacher> _genericRepository;

        public TeacherService(IGenericRepository<Teacher> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _genericRepository.GetAll();
        }

        public Teacher GetTeacherById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            return _genericRepository.Add(teacher);
        }

        public Teacher UpdateTeacher(int id, Teacher updatedTeacher)
        {
            var existingTeacher = _genericRepository.GetById(id);
            
            return _genericRepository.Update(existingTeacher, updatedTeacher);
        }

        public bool DeleteTeacher(int id)
        {
            return _genericRepository.Delete(id);
        }
    }
}
