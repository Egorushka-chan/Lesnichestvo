using Lesnichestvo.DAL.Models;

namespace Lesnichestvo.DAL.Interfaces
{
    public interface IProcedureRepository
    {
        public Task<List<WorkerMothlyDetailsFull>> GetWorkerMothlyDetailsFull(int workerId, DateTime? startDate, DateTime? endDate);
        public Task<List<FindingNameModel>> FindByName(string name);
    }
}
