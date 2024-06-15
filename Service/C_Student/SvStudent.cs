using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Service.MyDbContext;

namespace Service.C_Student
{
    public class SvStudent : ISvStudent
    {
        private MyContext _myDbContext;

        public SvStudent()
        {
            _myDbContext = new MyContext();
        }

        public Student Add_Students(Student student)
        {
            _myDbContext.Students.Add(student);
            _myDbContext.SaveChanges();

            return student;
        }

        public List<Student> GetAllStudents()
        {
            return _myDbContext.Students.ToList();
        }

        public Student Get_ById(int id)
        {
            return _myDbContext.Students.SingleOrDefault(x => x.Id == id);
        }
    }
}