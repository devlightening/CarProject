using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
