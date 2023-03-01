using Microsoft.AspNetCore.Mvc;

namespace DurationOfWorkOrder.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}