using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public interface IStudentsRepository
    {
        IEnumerable<Student> GetStudent(string Course);
        Student GetStudent(int id);

        IEnumerable<Student> GetStudent(IEnumerable<StudentCourse> sinCIds);
         IEnumerable<Student> AllStudent();
        Student Add(Student student);
        Student Update(Student updateStudent);
        Student Delete(int id);
    }
}
