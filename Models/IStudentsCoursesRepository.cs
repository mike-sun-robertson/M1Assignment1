using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public interface IStudentsCoursesRepository
    {
        IEnumerable<StudentCourse> GetStudent(int courseID);
        
        IEnumerable<StudentCourse> AllStudentsCourses();
        StudentCourse Add(StudentCourse studentCourse);
        StudentCourse Update(Student updateStudentCourse);
        StudentCourse Delete(int courseRegId);
    }
}
