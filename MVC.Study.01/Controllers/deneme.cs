using Microsoft.AspNetCore.Mvc;

namespace MVC.Study._01.Controllers
{
    public class deneme : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
