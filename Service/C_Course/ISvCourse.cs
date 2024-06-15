using Entities;

namespace Service.C_Course
{
    public interface ISvCourse
    {
        public List<Course> GetAllCourses();
        public Course Add_Courses(Course course);
        public Course Get_ById(int id);
    }
}