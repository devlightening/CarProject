using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ColorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
