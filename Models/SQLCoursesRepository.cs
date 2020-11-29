using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class SQLCoursesRepository : ICoursesRepository
    {
        private readonly LocalDbContext _context;

        public SQLCoursesRepository(LocalDbContext context)
        {
            this._context = context;
        }
        public Course Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
            //throw new NotImplementedException();
        }

        public IEnumerable<Course> AllCourse()
        {
            return _context.Courses;
        }

        public Course Delete(int id)
        {
            Course course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
            return course;
        }

        public Course GetCourses(int Id)
        {
            return _context.Courses.Find(Id);
        }

        public Course Update(Course updateCourse)
        {
            var course = _context.Courses.Attach(updateCourse);
            course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return updateCourse;
        }
    }
}
