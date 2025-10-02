using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL.Repositories
{
    internal class CustomerRepository(MainContext context) : BaseRepository<Customer>(context), ICustomerRepository
    {
        public Task<List<Customer>> FilterByNameTypeAndStatus(string? nameType, string? status, CancellationToken token)
        {
            var query = _context.Customers.AsQueryable();
            if (!string.IsNullOrEmpty(nameType))
            {
                query = query.Where(c => EF.Functions.Like(c.Name, $"%{nameType}%")
                    || EF.Functions.Like(c.CompanyType, $"%{nameType}%"));

            }
            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(c => EF.Functions.Like(c.Status, $"%{status}%"));
            }
            return query.ToListAsync(token);
        }
    }
}
