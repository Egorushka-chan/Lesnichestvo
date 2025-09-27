using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class DachaController(IBaseRepository<Dacha> repository) : DefaultEntityController<Dacha>(repository);
}
