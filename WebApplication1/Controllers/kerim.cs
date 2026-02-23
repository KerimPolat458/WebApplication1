using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    
    public class kerim : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
