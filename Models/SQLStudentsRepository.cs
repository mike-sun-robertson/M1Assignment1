using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class SQLStudentsRepository : IStudentsRepository
    {
        private readonly LocalDbContext _context;

        public SQLStudentsRepository(LocalDbContext context)
        {
            this._context = context;
        }
        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
            //throw new NotImplementedException();
        }

        public IEnumerable<Student> AllStudent()
        {
            return _context.Students;
        }

        public Student Delete(int id)
        {
            Student student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetStudent(string Course)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public Student Update(Student updateStudent)
        {
            var student = _context.Students.Attach(updateStudent);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            
            return updateStudent;
        }
    }
}
