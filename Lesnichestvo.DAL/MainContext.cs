using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL
{
    internal class MainContext(DbContextOptions<MainContext> options) : DbContext(options)
    {
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

        internal DbSet<WorkerMothlyDetailsFull> WorkerMothlyDetailsFulls { get; set; }
        internal DbSet<FindingNameModel> FindingNameModels { get; set; }
    }
}
