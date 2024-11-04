using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using System.Collections.Generic;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents() => _studentRepository.GetAllStudents();
        public Student GetStudentById(int id) => _studentRepository.GetStudentById(id);
        public void AddStudent(Student student) => _studentRepository.AddStudent(student);
        public bool UpdateStudent(int id, Student student)
        {
            var existingStudent = _studentRepository.GetStudentById(id);
            if (existingStudent == null) return false;

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Age = student.Age;
            existingStudent.School = student.School;

            return _studentRepository.UpdateStudent(existingStudent);
        }

        public bool DeleteStudent(int id) => _studentRepository.DeleteStudent(id);
    }
}
