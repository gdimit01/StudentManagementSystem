using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using System.Collections.Generic;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        private readonly IGenericRepository<Student> _genericRepository;

        public StudentService(IGenericRepository<Student> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _genericRepository.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _genericRepository.GetById(id);
        }
        
        public Student AddStudent(Student student)
        {
            return _genericRepository.Add(student);
        }
        
        public Student UpdateStudent(int id, Student updatedStudent)
        {
            var existingStudent = _genericRepository.GetById(id);
            
            return existingStudent == null ? null : _genericRepository.Update(existingStudent, updatedStudent);
        }

        public bool DeleteStudent(int id)
        {
            return _genericRepository.Delete(id);
        }
    }
}
