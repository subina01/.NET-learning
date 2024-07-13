using Microsoft.AspNetCore.Mvc;

namespace Session.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Subina");
            HttpContext.Session.SetInt32("Age", 32);
            return View();
        }

        public IActionResult Get()
        {
           

               var Name = HttpContext.Session.GetString("Name");
            var Age  = HttpContext.Session.GetInt32("Age").Value;
            ViewBag.Name = Name;
            ViewBag.Age = Age;


            return View();

        
        }

        
    }
}
