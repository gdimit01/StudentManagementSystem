using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound($"Could not find student with ID: {id}.");
            }
            
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody]Student student)
        {
            if (student == null)
            {
                return BadRequest("Student data is null.");
            }
            
            _studentService.AddStudent(student);
            
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody]Student updatedStudent)
        {
            if (updatedStudent == null || updatedStudent.Id != id)
            {
                return BadRequest("Student data is invalid or mismatched.");
            }
            
            var student = _studentService.UpdateStudent(id, updatedStudent);

            if (student == null)
            {
                return NotFound($"Could not find student with ID: {id}.");
            }

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (!_studentService.DeleteStudent(id))
            {
                return NotFound($"Could not find student with ID: {id}.");
            }

            return NoContent();
        }
    }
}
