using Lesnichestvo.Areas.Entities.Controllers.Default;
using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Areas.Entities.Controllers
{
    public class WorkController(IWorkRepository repository) : DefaultEntityController<Work>(repository)
    {
        public async Task<IActionResult> Filter(int? workerID, int? workID, CancellationToken token)
        {
            var result = await repository.FilterByWorkerAndWorkID(workerID, workID, token);
            ViewBag.WorkerID = workerID;
            ViewBag.WorkID = workID;
            return View("Index", result);
        }
    }
}