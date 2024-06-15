using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.C_Course;
using Service.C_Enrollment;
using Service.C_Level;
using Service.C_Major;
using Service.C_Student;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private ISvEnrollment svEnrollment;
        private ISvMajor svMajor;
        private ISvLevel svLevel;
        public EnrollmentController(ISvEnrollment svEnrollment, ISvMajor svMajor, ISvLevel svLevel)
        {
            this.svEnrollment = svEnrollment;
            this.svMajor = svMajor;
            this.svLevel = svLevel;
        }

        // GET: api/<EnrollmentController>
        [HttpGet]
        public IEnumerable<Enrollment> Get()
        {
            return svEnrollment.GetAllEnrrollments();
        }

        // GET api/<StudentController>/5
        [HttpGet("GetBy")]
        public List<Enrollment> Get(int idM, int idC, int idL)
        {
            return svEnrollment.Get_By(idM, idC, idL);
        }

        // POST api/<EnrollmentController>
        [HttpPost]
        public void Post([FromBody] Enrollment enrollment)
        {
            svEnrollment.Add_Enrollment(enrollment);
        }

        [HttpPost("Many")]
        public IActionResult Post([FromBody] List<Enrollment> enrollments)
        {
            svEnrollment.Add_Enrollments(enrollments);
            return Ok(enrollments);
        }


    }
}
