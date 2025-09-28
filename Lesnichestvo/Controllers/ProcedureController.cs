using Lesnichestvo.DAL.Interfaces;
using Lesnichestvo.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesnichestvo.Controllers
{
    public class ProcedureController(IProcedureRepository procedureRepository) : Controller
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
            List<WorkerMothlyDetailsFull> detailization =
                await procedureRepository.GetWorkerMothlyDetailsFull(workerID, startDate, endDate);

            ViewBag.HasResult = detailization.Count != 0;
            ViewBag.WorkerID = workerID;
            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;

            return View("Index", detailization);
        }
    }
}
