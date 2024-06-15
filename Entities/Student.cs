using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public Course? Courses { get; set; }
    }
}