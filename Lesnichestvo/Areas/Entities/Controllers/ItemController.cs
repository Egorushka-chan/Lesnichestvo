using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class ItemController(IBaseRepository<Item> repository) : DefaultEntityController<Item>(repository);
}