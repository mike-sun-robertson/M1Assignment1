using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class SQLStudentsCoursesRepository : IStudentsCoursesRepository
    {
        private readonly LocalDbContext _context;

        public SQLStudentsCoursesRepository(LocalDbContext context)
        {
            this._context = context;
        }
        public StudentCourse Add(StudentCourse studentCourse)
        {
            _context.StudentsCourses.Add(studentCourse);
            _context.SaveChanges();
            return studentCourse;
            //throw new NotImplementedException();
        }

        public IEnumerable<StudentCourse> AllStudentsCourses()
        {
            return _context.StudentsCourses;
        }

        public StudentCourse Delete(int courseRegId)
        {
            StudentCourse studentCourse = _context.StudentsCourses.Find(courseRegId);
            if (studentCourse != null)
            {
                _context.StudentsCourses.Remove(studentCourse);
                _context.SaveChanges();
            }
            return studentCourse;
        }

        public IEnumerable<StudentCourse> GetStudent(int courseID)
        {
            return _context.StudentsCourses.Where(a => a.CourseId == courseID);
        }

        
        public StudentCourse Update(Student updateStudentCourse)
        {
            throw new NotImplementedException();
        }
    }
}
