using Entities;
using Microsoft.AspNetCore.Mvc;
using Service.C_Level;
using System.Reflection.Emit;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_PruebaEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private ISvLevel svLevel;
        public LevelController(ISvLevel svLevel)
        {
            this.svLevel = svLevel;
        }
        [HttpGet]
        public IEnumerable<Level> Get()
        {
            return svLevel.GetAllLevel();
        }


        // POST api/<LevelController>
        [HttpPost]
        public void Post([FromBody] Level level)
        {
            svLevel.Add_Level(level);

        }

    }
}