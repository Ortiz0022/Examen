using System;
using Service.C_Enrollment;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Service.MyDbContext;
using Microsoft.EntityFrameworkCore;

namespace Service.C_Enrollment
{
    public class SvEnrollment : ISvEnrollment
    {
        private MyContext _myDbContext;
        public SvEnrollment()
        {
            _myDbContext = new MyContext();
        }
        public Enrollment Add_Enrollment(Enrollment enrollment)
        {
            _myDbContext.Enrollments.Add(enrollment);
            _myDbContext.SaveChanges();

            return enrollment;
        }

        public List<Enrollment> Add_Enrollments(List<Enrollment> enrollments)
        {
            foreach (var enrollment in enrollments)
            {
                _myDbContext.Enrollments.Add(enrollment);
            }
            _myDbContext.SaveChanges();

            return enrollments;
        }

        public List<Enrollment> Get_By(int idM, int idC, int idL )
        {
            if(idM > 0)
            {
                return _myDbContext.Enrollments.Include(x => x.Student).Where(x => x.Course.MajorId == idM).ToList();
            }
            else if(idC > 0)
            {
                return _myDbContext.Enrollments.Include(x => x.Student).Where(x => x.Course.Id == idC).ToList();
            }
            else if(idL > 0 && idM > 0) 
            {
                return _myDbContext.Enrollments.Include(x => x.Student).Where(x => x.Course.LevelId == idL && x.Course.MajorId == idM).ToList();
            }
            return _myDbContext.Enrollments.Include(x => x.Course).ToList();
        }

        public List<Enrollment> GetAllEnrrollments()
        {
            return _myDbContext.Enrollments.Include(x => x.Student).Include(x => x.Course).ThenInclude(x => x.Levels).Include(x => x.Course.Majors).ToList();
        }
    }
}
