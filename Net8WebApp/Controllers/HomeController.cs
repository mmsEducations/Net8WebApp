using Microsoft.AspNetCore.Mvc;
using Net8WebApp.Business;

namespace WebAppEmty.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;

        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();

            //StudentService _studentService = new StudentService();
            return View(students);
        }
    }
}
