using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CarImagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
