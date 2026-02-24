using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class inanc : Controller
    {
        public IActionResult Index()
        {
            int a = 1;
            return View();
        }
    }
}
