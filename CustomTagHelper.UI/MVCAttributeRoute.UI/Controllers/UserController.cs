using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using MVCAttributeRoute.UI.Models;

namespace MVCAttributeRoute.UI.Controllers
{
    [Route("kullanici")]
    public class UserController : Controller
    {
        
        private static List<User> users = new List<User>()
        {
            new User { Id = 1, Name = "Baran", Email = "baran@mail.com" },
            new User { Id = 2, Name = "Ahmet", Email = "ahmet@mail.com" }
        };

        [HttpGet("listele")]
        public IActionResult Liste()
        {
            ViewData["Users"] = users;
            return View();
        }

        [HttpGet("ekle")]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost("ekle")]
        public IActionResult Ekle(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Liste");
        }
    }
}
