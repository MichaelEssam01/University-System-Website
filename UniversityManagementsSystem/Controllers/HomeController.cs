using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Polly;
using System.Diagnostics;
using UniversityManagementsSystem.Models;
using UniversityManagementSystem.Data; // Make sure to include the namespace for your DbContext



namespace UniversityManagementsSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context; // Assign the DbContext

        }

        public IActionResult Index()
        {
            var studentsCount = _context.Users.Count();
            var departmentsCount = _context.Departments.Count(); // Assuming departments represent branches
            var coursesCount = _context.Courses.Count();

            // Pass counts to the view
            ViewData["StudentsCount"] = studentsCount;
            ViewData["DepartmentsCount"] = departmentsCount;
            ViewData["CoursesCount"] = coursesCount;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
