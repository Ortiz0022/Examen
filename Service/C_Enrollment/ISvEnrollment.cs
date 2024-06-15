using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.C_Enrollment
{
    public interface ISvEnrollment
    {
        public Enrollment Add_Enrollment(Enrollment enrollment);

        public List<Enrollment> GetAllEnrrollments();


        public List<Enrollment> Get_By(int idM, int idC, int idL);

        public List<Enrollment> Add_Enrollments(List<Enrollment> enrollments);

    }
}
