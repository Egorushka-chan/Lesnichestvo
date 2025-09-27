using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL
{
    public class MainContext(DbContextOptions<MainContext> options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EGOR\\SQLEXPRESS;Initial Catalog=Lesnichestvo;Integrated Security=True;TrustServerCertificate=True");
            
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dacha> Dachas { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Item> Inventory { get; set; }
        public DbSet<Mapping> Mapping { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<QuartalNetwork> QuartalNetworks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SoldWood> SoldWood { get; set; }
        public DbSet<UnsoldWood> UnsoldWood { get; set; }
        public DbSet<WoodType> WoodTypes { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkHasInventory> WorkHasInventory { get; set; }
        public DbSet<WorkHasWorkers> WorkHasWorkers { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<User> Users { get; set; }

        private DbSet<WorkerMothlyDetailsFull> WorkerMothlyDetailsFulls { get; set; }

        public async Task<List<WorkerMothlyDetailsFull>> GetWorkerMothlyDetailsFull(int workerId, DateTime? startDate, DateTime? endDate)
        {
            var res = await this.WorkerMothlyDetailsFulls
                .FromSqlRaw("Exec [dbo].[GetWorkerMonthlyDetailsFull] @p0, @p1, @p2",
                    workerId, (object?)startDate ?? DBNull.Value, (object?)endDate ?? DBNull.Value)
                .ToListAsync();
            return res;
        }
    }
}
