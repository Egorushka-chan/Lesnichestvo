using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL.Repositories
{
    internal class WorkRepository(MainContext context) : BaseRepository<Work>(context), IWorkRepository
    {
        public Task<List<Work>> FilterByWorkerAndWorkID(int? workerID, int? workID, CancellationToken token)
        {
            var query = _context.Works.AsQueryable();
            if (workerID.HasValue)
            {
                query = query.Where(w => w.Workers.Any(whw => whw.WorkerID == workerID.Value));
            }
            if (workID.HasValue)
            {
                query = query.Where(w => w.ID == workID.Value || w.PreviousWorkID == workID.Value);
            }
            return query.ToListAsync(token);
        }
    }
}
