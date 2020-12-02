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
        
        public IEnumerable<Student> GetStudent(IEnumerable<StudentCourse> sinCIds)
        {
            //FROM B WHERE name IN (select name from A where id = xxxx)
            //_studentsRepository.Where(a => a.CourseId == courseID);
            //var itemIds = EF.Item.Where(x => x.ItemName == "沙发").Select(x=>x.ID);
            //var suplist = EF.Sup.Where(x => itemIds.Contains(x.supID)).Select(x => x.supName);
            //return _context.Students.Where(x => sinCIds.Contains(x.StudentId));
            //throw new NotImplementedException();
            return from stu in _context.Students
                   join sinC in sinCIds
                   on stu.StudentId equals sinC.StudentId
                   select stu;
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
