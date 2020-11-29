using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class MockCoursesRepository : ICoursesRepository
    {
        private List<Course> _courses;
        public MockCoursesRepository()
        {
            //CourseId, Course Number, Course Name, and Description
            _courses = new List<Course>
            {
                new Course{ CourseId=1, CourseName= "Math",CourseNumber="111", Description="Math description"},
                new Course{ CourseId=2, CourseName= "English",CourseNumber="222", Description="English description"},
                new Course{ CourseId=3, CourseName= "French",CourseNumber="333", Description="French description"},
                new Course{ CourseId=4, CourseName= "Art",CourseNumber="444", Description="Art description"},
                new Course{ CourseId=5, CourseName= "Sports",CourseNumber="555", Description="Sports description"},


            };
        }

        public Course Add(Course course)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> AllCourse()
        {
            return _courses;
        }

        public Course Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourses(int Id)
        {
            throw new NotImplementedException();
        }

        public Course Update(Course updateCourse)
        {
            throw new NotImplementedException();
        }
    }
}
