using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class SQLInstructorsRepository : IInstructorsRepository
    {
        private readonly LocalDbContext _context;

        public SQLInstructorsRepository(LocalDbContext context)
        {
            _context = context;
        }
        public Instructor Add(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return instructor;
            //throw new NotImplementedException();
        }

        public IEnumerable<Instructor> AllInstructor()
        {
            return _context.Instructors;
        }

        public Instructor Delete(int id)
        {
            Instructor instructor = _context.Instructors.Find(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
            return instructor;
        }

        public Instructor GetInstructor(int InstructorId)
        {
            return _context.Instructors.Find(InstructorId); ;
        }

        public Instructor Update(Instructor updateInstructor)
        {
            var instructor = _context.Instructors.Attach(updateInstructor);
            instructor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return updateInstructor;
        }
    }
}
