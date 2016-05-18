using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Logistics.Domain.Model.Client;
using Logistics.Domain.Model.Courier;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;
using Logistics.Domain.Model.Report;
using Logistics.Infrastructure.Seed;

namespace Logistics.Infrastructure
{
    public class AppContext : DbContext
    {
        public AppContext() : base("Logistics")
        {
            Database.SetInitializer(new AppContextSeedInitializer());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
