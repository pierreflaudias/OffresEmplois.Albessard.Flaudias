using Model.Entities;
using System.Data.Entity;
using System.Reflection;

namespace Model.FluentEntities
{
    public class ContextFluent : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Postulation> Postulations { get; set; }

        public DbSet<Status> Statuses { get; set; }


        public ContextFluent() :base("name=OffresEmploisConnection")
        {
            Database.SetInitializer<ContextFluent>(new CreateDatabaseIfNotExists<ContextFluent>());
            Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("offers");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
