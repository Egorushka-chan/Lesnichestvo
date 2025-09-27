using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class WorkHasInventoryController(IBaseRepository<WorkHasInventory> repository) : DefaultEntityController<WorkHasInventory>(repository);
}