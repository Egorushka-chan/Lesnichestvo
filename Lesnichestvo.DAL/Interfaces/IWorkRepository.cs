using Lesnichestvo.DAL.Entities;

namespace Lesnichestvo.DAL.Interfaces
{
    public interface IWorkRepository : IBaseRepository<Work>
    {
        public Task<List<Work>> FilterByWorkerAndWorkID(int? workerID, int? workID, CancellationToken token);
    }
}
