using Lesnichestvo.DAL.Interfaces;
using Lesnichestvo.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL.Repositories
{
    internal class ProcedureRepository(MainContext context) : IProcedureRepository
    {
        public async Task<List<FindingNameModel>> FindByName(string name)
        {
            List<FindingNameModel> res = await context.FindingNameModels
                .FromSqlRaw("Exec [dbo].[FindByName] @p0", name)
                .ToListAsync();
            return res;
        }

        public async Task<List<WorkerMothlyDetailsFull>> GetWorkerMothlyDetailsFull(int workerId, DateTime? startDate, DateTime? endDate)
        {
            var res = await context.WorkerMothlyDetailsFulls
                .FromSqlRaw("Exec [dbo].[GetWorkerMonthlyDetailsFull] @p0, @p1, @p2",
                    workerId, (object?)startDate ?? DBNull.Value, (object?)endDate ?? DBNull.Value)
                .ToListAsync();
            return res;
        }
    }
}
