using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Controllers
{
    public class CustomerController(IBaseRepository<Customer> repository) : DefaultEntityController<Customer>(repository);
}
