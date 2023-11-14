using Microsoft.AspNetCore.Mvc;
using Task1_ASP.Models;

namespace Task1_ASP.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher = new Teacher()
            {
                Id = 1,
                Name = "Anar",
            };
            Teacher teacher1 = new Teacher()
            {
                Id = 2,
                Name = "Ilkin"
            };
            Teacher teacher2 = new Teacher()
            {
                Id = 3,
                Name = "Yadigar"
            };

            return View();
        }
    }
}
