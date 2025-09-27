using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class UnsoldWoodController(IBaseRepository<UnsoldWood> repository) : DefaultEntityController<UnsoldWood>(repository);
}