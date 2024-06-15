using Entities;
using Service.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.C_Major
{
    public class SvMajor : ISvMajor
    {

        private MyContext _myDbContext;
        public SvMajor()
        {
            _myDbContext = new MyContext();
        }
        public Major Add_Major(Major major)
        {
            _myDbContext.Majors.Add(major);
            _myDbContext.SaveChanges();

            return major;
        }

        public List<Major> GetAllMajors()
        {
            return _myDbContext.Majors.ToList();
        }

        public Major Get_ById(int id)
        {
            return _myDbContext.Majors.Find(id);
        }
    }
}
