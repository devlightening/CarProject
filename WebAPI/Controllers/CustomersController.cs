using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
