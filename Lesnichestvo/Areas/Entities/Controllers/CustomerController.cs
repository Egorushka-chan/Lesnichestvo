using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class CustomerController(IBaseRepository<Customer> repository) : DefaultEntityController<Customer>(repository);
}
