using Entities;

namespace Service.C_Student
{
    public interface ISvStudent
    {
        public List<Student> GetAllStudents();
        public Student Add_Students(Student student);

        public Student Get_ById(int id);
    }
}