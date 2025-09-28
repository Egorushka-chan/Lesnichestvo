using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    public class FindingController(IProcedureRepository procedureRepository) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FindingName(string? name)
        {
            if(name is null)
            {
                return View("Index");
            }

            var res = await procedureRepository.FindByName(name);

            ViewBag.Name = name;

            return View("Index", res);
        }
    }
}
