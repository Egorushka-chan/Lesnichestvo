using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class CustomerController(ICustomerRepository repository) : DefaultEntityController<Customer>(repository)
    {
        public async Task<IActionResult> Filter(string? nameType, string? status, CancellationToken token)
        {
            List<Customer> result = await repository.FilterByNameTypeAndStatus(nameType, status, token);
            ViewBag.NameType = nameType;
            ViewBag.Status = status;
            return View("Index", result);
        }
    }
}
