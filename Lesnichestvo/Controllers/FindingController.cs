using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    public class FindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
