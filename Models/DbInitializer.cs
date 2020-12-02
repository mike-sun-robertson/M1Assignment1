using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class DbInitializer
    {
        public static void Initialize(LocalDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student {  FirstName="Aaa",LastName="Aa",EmailAddress="aaa@111.com",PhoneNumber="2043114501", Course="Math"},
                new Student { FirstName="Bbb",LastName="Bb",EmailAddress="aaa@111.com",PhoneNumber="2043114502", Course="Math"},
                new Student {  FirstName="Ccc",LastName="Cc",EmailAddress="aaa@111.com",PhoneNumber="2043114503", Course="English"},
                new Student {  FirstName="Ddd",LastName="Dd",EmailAddress="aaa@111.com",PhoneNumber="2043114504", Course="French"},
                new Student {  FirstName="Eee",LastName="Ee",EmailAddress="aaa@111.com",PhoneNumber="2043114505", Course="Art"},
                new Student {  FirstName="Fff",LastName="Ff",EmailAddress="aaa@111.com",PhoneNumber="2043114506", Course="Sports"},
                new Student {  FirstName="Ggg",LastName="Gg",EmailAddress="aaa@111.com",PhoneNumber="2043114507", Course="sports"},
                new Student {  FirstName="Hhh",LastName="Hh",EmailAddress="aaa@111.com",PhoneNumber="2043114508", Course="Math"},
                new Student {  FirstName="Iii",LastName="Ii",EmailAddress="aaa@111.com",PhoneNumber="2043114509", Course="Art"},
                new Student {  FirstName="Jjj",LastName="Jj",EmailAddress="aaa@111.com",PhoneNumber="2043114510", Course="French"},
                new Student {  FirstName="Kkk",LastName="Kk",EmailAddress="aaa@111.com",PhoneNumber="2043114511", Course="Math"},
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{ CourseName= "Math",CourseNumber="111", Description="Math description"},
                new Course{ CourseName= "English",CourseNumber="222", Description="English description"},
                new Course{ CourseName= "French",CourseNumber="333", Description="French description"},
                new Course{ CourseName= "Art",CourseNumber="444", Description="Art description"},
                new Course{ CourseName= "Sports",CourseNumber="555", Description="Sports description"},
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var instructors = new Instructor[]
            {

            new Instructor(){ FirstName="Mike", LastName="Ai", EmailAddress="mike@111.com", Course="Math"},
            new Instructor(){ FirstName="Neil", LastName="Bi", EmailAddress="neil@222.com", Course="English"},
            new Instructor(){ FirstName="Ellie", LastName="Ci", EmailAddress="ellie@333.com", Course="French"},
            new Instructor(){ FirstName="Sam", LastName="Di", EmailAddress="sam@444.com", Course="Art"},
            new Instructor(){ FirstName="Bill", LastName="Ei", EmailAddress="bill@666.com", Course="Sports"}

            };
            foreach (Instructor sc in instructors)
            {
                context.Instructors.Add(sc);
            }
            context.SaveChanges();

            var studentCourses = new StudentCourse[]
            {

            new StudentCourse(){ StudentId=1, CourseId=1},
            new StudentCourse(){ StudentId=1, CourseId=2},
            new StudentCourse(){ StudentId=1, CourseId=3},
            new StudentCourse(){ StudentId=1, CourseId=4},
            new StudentCourse(){ StudentId=1, CourseId=5},
            new StudentCourse(){ StudentId=2, CourseId=1},
            new StudentCourse(){ StudentId=2, CourseId=2},
            new StudentCourse(){ StudentId=2, CourseId=3},
            new StudentCourse(){ StudentId=3, CourseId=1},
            new StudentCourse(){ StudentId=4, CourseId=2},
            new StudentCourse(){ StudentId=5, CourseId=3},
            new StudentCourse(){ StudentId=6, CourseId=4},
            new StudentCourse(){ StudentId=7, CourseId=5},
            new StudentCourse(){ StudentId=8, CourseId=1},
            new StudentCourse(){ StudentId=9, CourseId=2},
            new StudentCourse(){ StudentId=10, CourseId=3},
            new StudentCourse(){ StudentId=10, CourseId=4},
            new StudentCourse(){ StudentId=4, CourseId=5},

            };
            foreach (StudentCourse f in studentCourses)
            {
                context.StudentsCourses.Add(f);
            }
            context.SaveChanges();
        }
    }
}
