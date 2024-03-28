using DependencyInjection.Models;
using DependencyInjection.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _student;
        public StudentController(IStudentRepo student)
        {
            _student = student;
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentModel Student)
        {
            _student.AddStudent(Student);
            return Ok("Student Added.");
            //return Ok(_student.GetStudents());
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_student.GetStudents());
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok(_student.DeleteStudent(id));
        }
    }
}
