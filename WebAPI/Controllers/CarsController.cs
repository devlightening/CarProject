using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
