using Web.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int personId)
        {
            var person = new PersonModel { Id = 1, Age = 23, CreatedDate = DateTime.UtcNow, Name = "Nika" };
            return View(person);
        }
    }
}