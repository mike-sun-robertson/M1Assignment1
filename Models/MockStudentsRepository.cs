using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class MockStudentsRepository : IStudentsRepository
    {
        private List<Student> _students;
        public MockStudentsRepository()
        {
            //InstructorId, First Name, Last Name, 
            //Email address, and the Course that they teach
            _students = new List<Student>
            { //StudentId, First Name, Last Name, Email address, and Phone number.
                new Student { StudentId=1, FirstName="Aaa",LastName="Aa",EmailAddress="aaa@111.com",PhoneNumber="2043114501", Course="Math"},
                new Student { StudentId=2, FirstName="Bbb",LastName="Bb",EmailAddress="aaa@111.com",PhoneNumber="2043114502", Course="Math"},
                new Student { StudentId=3, FirstName="Ccc",LastName="Cc",EmailAddress="aaa@111.com",PhoneNumber="2043114503", Course="English"},
                new Student { StudentId=4, FirstName="Ddd",LastName="Dd",EmailAddress="aaa@111.com",PhoneNumber="2043114504", Course="French"},
                new Student { StudentId=5, FirstName="Eee",LastName="Ee",EmailAddress="aaa@111.com",PhoneNumber="2043114505", Course="Art"},
                new Student { StudentId=6, FirstName="Fff",LastName="Ff",EmailAddress="aaa@111.com",PhoneNumber="2043114506", Course="Sports"},
                new Student { StudentId=7, FirstName="Ggg",LastName="Gg",EmailAddress="aaa@111.com",PhoneNumber="2043114507", Course="sports"},
                new Student { StudentId=8, FirstName="Hhh",LastName="Hh",EmailAddress="aaa@111.com",PhoneNumber="2043114508", Course="Math"},
                new Student { StudentId=9, FirstName="Iii",LastName="Ii",EmailAddress="aaa@111.com",PhoneNumber="2043114509", Course="Art"},
                new Student { StudentId=10, FirstName="Jjj",LastName="Jj",EmailAddress="aaa@111.com",PhoneNumber="2043114510", Course="French"},
                new Student { StudentId=11, FirstName="Kkk",LastName="Kk",EmailAddress="aaa@111.com",PhoneNumber="2043114511", Course="Math"},

            };
            }

        public Student Add(Student student)
        {
            //throw new NotImplementedException();
            student.StudentId = _students.Max(s => s.StudentId) + 1;
            _students.Add(student);
            return student;
        }

        public IEnumerable<Student> AllStudent()
        {
            return _students;
        }

        public Student Delete(int id)
        {
            Student student = _students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                _students.Remove(student);
            }
            return student;
            //throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudent(string Course)
        {
            return _students.Where(a=> a.Course==Course );
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudent(IEnumerable<StudentCourse> sinCIds)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student updateStudent)
        {
            Student student = _students.FirstOrDefault(s => s.StudentId == updateStudent.StudentId);
            if (student != null)
            {
                student.FirstName= updateStudent.FirstName;
                student.LastName = updateStudent.LastName;
                student.PhoneNumber = updateStudent.PhoneNumber;
                student.EmailAddress = updateStudent.EmailAddress;
                
            }
            return student;
            //throw new NotImplementedException();
        }
    }
}
