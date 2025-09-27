using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class WoodTypeController(IBaseRepository<WoodType> repository) : DefaultEntityController<WoodType>(repository);
}