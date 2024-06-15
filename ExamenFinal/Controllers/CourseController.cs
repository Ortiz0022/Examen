using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.C_Course;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ISvCourse svCourse;

        public CourseController(ISvCourse svCourse)
        {
            this.svCourse = svCourse;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return svCourse.GetAllCourses();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return svCourse.Get_ById(id);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            svCourse.Add_Courses(course);
        }

    }
}