using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseRepository<User> _userRepository;

        public HomeController(ILogger<HomeController> logger, IBaseRepository<User> userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
