using Lesnichestvo.DAL;
using Lesnichestvo.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    public class ProcedureController(MainContext mainContext) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetWorkerMothlyDetailsFull(
            int workerID, 
            DateTime? startDate, 
            DateTime? endDate)
        {
            List<WorkerMothlyDetailsFull> detailization = await mainContext.GetWorkerMothlyDetailsFull(workerID, startDate, endDate);

            ViewBag.HasResult = detailization.Count != 0;
            ViewBag.WorkerID = workerID;
            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;

            return View("Index", detailization);
        }
    }
}
