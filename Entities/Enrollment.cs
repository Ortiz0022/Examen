using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [JsonIgnore]
        public Student? Student { get; set; }
        [JsonIgnore]
        public Course? Course { get; set; }
    }
}
