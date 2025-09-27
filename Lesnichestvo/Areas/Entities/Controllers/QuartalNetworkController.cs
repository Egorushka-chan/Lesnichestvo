using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class QuartalNetworkController(IBaseRepository<QuartalNetwork> repository) : DefaultEntityController<QuartalNetwork>(repository);
}