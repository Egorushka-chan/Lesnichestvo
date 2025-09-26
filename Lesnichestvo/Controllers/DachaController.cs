using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Controllers
{
    public class DachaController(IBaseRepository<Dacha> repository) : DefaultEntityController<Dacha>(repository);
}
