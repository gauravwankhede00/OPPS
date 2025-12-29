using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult actionResult()
        {
           var a =  PartialView();
            return a;
        }
    }
}
