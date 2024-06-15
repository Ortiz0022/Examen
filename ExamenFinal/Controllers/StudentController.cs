using Microsoft.AspNetCore.Mvc;
using Entities;
using Service.C_Student;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private ISvStudent svStudent;

        public StudentController(ISvStudent svStudent)
        {
            this.svStudent = svStudent;
        }


        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return svStudent.GetAllStudents();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return svStudent.Get_ById(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            svStudent.Add_Students(student);
        }

    }
}