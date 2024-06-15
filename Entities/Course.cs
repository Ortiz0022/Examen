using System.Text.Json.Serialization;

namespace Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int LevelId { get; set; }
        public int MajorId { get; set; }
        [JsonIgnore]
        public Level? Levels { get; set; }
        [JsonIgnore]

        public Major? Majors { get; set; }
        [JsonIgnore]

        public List<Student>? Students { get; set; }

    }
}