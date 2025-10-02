using Lesnichestvo.DAL.Entities;

namespace Lesnichestvo.DAL.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        public Task<List<Customer>> FilterByNameTypeAndStatus(string? nameType, string? status, CancellationToken token);
    }
}
