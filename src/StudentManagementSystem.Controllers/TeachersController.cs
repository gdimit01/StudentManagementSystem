using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Services;
using StudentManagementSystem.Models;
using System.Linq;  // Add this

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly TeacherService _teacherService;

        public TeachersController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // GET: api/teachers
        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            var teachers = _teacherService.GetAllTeachers();
            return Ok(teachers);
        }

        // GET: api/teachers/{id}
        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            
            if (teacher == null)
            {
                return NotFound($"Teacher with ID {id} not found.");
            }
            return Ok(teacher);
        }

        // POST: api/teachers
        [HttpPost]
        public IActionResult CreateTeacher([FromBody] Teacher teacher)
        {
            if (teacher == null)
            {
                return BadRequest("Teacher data is null.");
            }

            _teacherService.AddTeacher(teacher);
            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.Id }, teacher);
        }

        // PUT: api/teachers/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTeacher(int id, [FromBody] Teacher updatedTeacher)
        {
            if (updatedTeacher == null || updatedTeacher.Id != id)
            {
                return BadRequest("Teacher data is invalid or mismatched.");
            }

            var teacher = _teacherService.UpdateTeacher(id, updatedTeacher);

            if (teacher == null)
            {
                return NotFound($"Could not find teacher with ID: {id}.");
            }

            return Ok(teacher);
        }

        // DELETE: api/teachers/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            if (!_teacherService.DeleteTeacher(id))
            {
                return NotFound($"Could not find student with ID: {id}.");
            }

            return NoContent();
        }
    }
}
