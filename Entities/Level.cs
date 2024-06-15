using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace Entities
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<Course>? Courses { get; set;}
    }
}