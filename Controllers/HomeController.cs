using M1Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace M1Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInstructorsRepository _instructorsRepository;
        private readonly IStudentsRepository _studentsRepository;
        private readonly ICoursesRepository _coursesRepository;
        private readonly IStudentsCoursesRepository _studentsCoursesRepository;

       public HomeController(IInstructorsRepository instructorsRepository, IStudentsRepository studentsRepository, ICoursesRepository coursesRepository, IStudentsCoursesRepository studentsCoursesRepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _instructorsRepository = instructorsRepository;
            _studentsRepository = studentsRepository;
            _coursesRepository = coursesRepository;
            _studentsCoursesRepository =  studentsCoursesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InstructorsView()
        //public List<Instructor> InstructorsView()
        {
            //This is my previous problem I give the number to an key col, so I can't create mock data
            //Instructor instest = new Instructor() { ///InstructorId = 1//, FirstName = "Mike", LastName = "Ai", EmailAddress = "mike@111.com", Course = "Math" };
            //_instructorsRepository.Add(instest);
            IEnumerable<Instructor> model = _instructorsRepository.AllInstructor();
            return View(model);
        }
        public IActionResult StudentsView()
        {
            IEnumerable<Student> model = _studentsRepository.AllStudent();
            return View(model);
        }
        public IActionResult StudentsListView(int id)
        {
            IEnumerable<StudentCourse> model = _studentsCoursesRepository.GetStudent(id);
            return View(model);
        }
        public IActionResult CoursesView()
        {
            
            IEnumerable<Course> model = _coursesRepository.AllCourse();
            return View(model);
        }

        public IActionResult GetStudentsbyCourseview(int CourseId)
        { //GetStudentsbyCourseview
          //IEnumerable<StudentCourse> model = _studentsCoursesRepository.GetStudent(id);

            ViewData["PageTitle"] = _coursesRepository.GetCourses(CourseId).CourseName;
            IEnumerable < StudentCourse > sinCId=  _studentsCoursesRepository.GetStudent(CourseId);
            var studentsincourse = _studentsRepository.GetStudent(sinCId);
            return PartialView("StudentsListView", studentsincourse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
