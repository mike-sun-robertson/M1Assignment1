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

        public HomeController(IInstructorsRepository instructorsRepository,IStudentsRepository studentsRepository,ICoursesRepository coursesRepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _instructorsRepository = instructorsRepository;
            _studentsRepository = studentsRepository;
            _coursesRepository = coursesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InstructorsView()
        //public List<Instructor> InstructorsView()
        {
            //return _instructorsRepository.AllInstructor();
            IEnumerable<Instructor> model = _instructorsRepository.AllInstructor();
            return View(model);
        }
        public IActionResult StudentsView()
        {
            IEnumerable<Student> model = _studentsRepository.AllStudent();
            return View(model);
        }
        public IActionResult StudentsListView(string id)
        {
            IEnumerable<Student> model = _studentsRepository.GetStudent(id);
            return View(model);
        }
        public IActionResult CoursesView()
        {
            IEnumerable<Course> model = _coursesRepository.AllCourse();
            return View(model);
        }

        public IActionResult GetStudentsbyCourseview(string CourseName)
        { //GetStudentsbyCourseview
            var studentsincourse = _studentsRepository.GetStudent(CourseName);
            return PartialView("StudentsListView", studentsincourse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
