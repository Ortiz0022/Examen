using Entities;
using Microsoft.EntityFrameworkCore;
using Service.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.C_Course
{
    public class SvCourse : ISvCourse
    {
        private MyContext _myDbContext;

        public SvCourse()
        {
            _myDbContext = new MyContext();
        }
        public Course Add_Courses(Course course)
        {
            _myDbContext.Courses.Add(course);
            _myDbContext.SaveChanges();

            return course;
        }

        public List<Course> GetAllCourses()
        {
            return _myDbContext.Courses.Include(x => x.Majors).Include(x => x.Levels).ToList();
        }

        public Course Get_ById(int id)
        {
            return _myDbContext.Courses.SingleOrDefault(x => x.Id == id);
        }
    }
}