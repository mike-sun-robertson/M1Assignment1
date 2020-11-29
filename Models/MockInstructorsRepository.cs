using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class MockInstructorsRepository : IInstructorsRepository
    {
        private List<Instructor> _instructors;
        public MockInstructorsRepository()
        {
            //InstructorId, First Name, Last Name, 
            //Email address, and the Course that they teach
            _instructors = new List<Instructor> {
            new Instructor(){ InstructorId=1, FirstName="Mike", LastName="Ai", EmailAddress="mike@111.com", Course="Math"},
            new Instructor(){ InstructorId=2, FirstName="Neil", LastName="Bi", EmailAddress="neil@222.com", Course="English"},
            new Instructor(){ InstructorId=3, FirstName="Ellie", LastName="Ci", EmailAddress="ellie@333.com", Course="French"},
            new Instructor(){ InstructorId=4, FirstName="Sam", LastName="Di", EmailAddress="sam@444.com", Course="Art"},
            new Instructor(){ InstructorId=5, FirstName="Bill", LastName="Ei", EmailAddress="bill@666.com", Course="Sports"}

            };

        }

        public Instructor Add(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> AllInstructor()
        {
            return _instructors;
        }

        public Instructor Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor GetInstructor(int InstructorId)
        {
            throw new NotImplementedException();
        }

        public Instructor Update(Instructor updateInstructor)
        {
            throw new NotImplementedException();
        }
    }
}
