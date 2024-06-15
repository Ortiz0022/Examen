using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.C_Course;
using Service.C_Major;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorController : ControllerBase
    {

        private ISvMajor svMajor;

        public MajorController(ISvMajor svMajor)
        {
            this.svMajor = svMajor;
        }
        // GET: api/<MajorController>
        [HttpGet]
        public IEnumerable<Major> Get()
        {
            return svMajor.GetAllMajors();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id Major}")]
        public Major Get(int id)
        {
            return svMajor.Get_ById(id);
        }


        // POST api/<MajorController>
        [HttpPost]
        public void Post([FromBody] Major major)
        {
            svMajor.Add_Major(major);
        }
    }
}
