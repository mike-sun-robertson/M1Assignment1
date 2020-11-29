using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{

    public interface IInstructorsRepository
    {
        Instructor GetInstructor(int InstructorId);
        IEnumerable<Instructor> AllInstructor();
        Instructor Add(Instructor instructor);
        Instructor Update(Instructor updateInstructor);
        Instructor Delete(int id);

    }
}
