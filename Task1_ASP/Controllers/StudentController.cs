using Microsoft.AspNetCore.Mvc;
using Task1_ASP.Models;

namespace Task1_ASP.Controllers
{
    public class StudentController : Controller
    {
        Student student = new Student()
        {
            Id = 1,
            Name = "Farid",
            Surname = "Alizade",
            ImagePath = "image/1",
            GroupId = 1,
        };
        Student student1 = new Student()
        {
            Id = 2,
            Name = "Seid",
            Surname = "Bayramov",
            ImagePath = "image/2",
            GroupId = 2,
        };
        Student student2 = new Student()
        {
            Id = 3,
            Name = "Ceyhun",
            Surname = "Agayev",
            ImagePath = "image/3",
            GroupId = 1,
        };
        Student student3 = new Student()
        {
            Id = 4,
            Name = "Tunay",
            Surname = "Huseynov",
            ImagePath = "image/4",
            GroupId = 2,
        };
        Student student4 = new Student()
        {
            Id = 5,
            Name = "Cavidan",
            Surname = "Alizade",
            ImagePath = "image/5",
            GroupId = 1,
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
