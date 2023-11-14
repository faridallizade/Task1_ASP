using Microsoft.AspNetCore.Mvc;
using Task1_ASP.Models;

namespace Task1_ASP.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            List<Group> groups = new List<Group>();
            Group group = new Group()
            {
                Id = 1,
                Name = "Tk-91",

            };
            Group group1 = new Group()
            {
                Id=2,
                Name = "022-S1"
            };
            groups.Add(group);
            groups.Add(group1);
            return View();
        }
    }
}
