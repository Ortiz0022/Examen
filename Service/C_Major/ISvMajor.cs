using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.C_Major
{
    public interface ISvMajor
    {
        public List<Major> GetAllMajors();
        public Major Add_Major(Major major);
        public Major Get_ById(int id);


    }
}
