using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace DAL
{
    public class RentalContext : DbContext
    {
        public DbSet<Person> people { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Service> person { get; set; }
        public DbSet<House> houses { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Boat> boats { get; set; }
        public DbSet<Rent> rents { get; set; }
        public DbSet<InvoiceLine> invoiceLines { get; set; }
        public DbSet<Invoice> invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("People");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Service>().ToTable("Services");
            modelBuilder.Entity<House>().ToTable("Houses");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Service>().ToTable("Services");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<House>().ToTable("Houses");
            modelBuilder.Entity<Boat>().ToTable("Boats");

            modelBuilder.Entity<Rent>()
                .HasRequired(r => r.employee)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .HasRequired(r => r.client)
                .WithMany()
                .WillCascadeOnDelete(false);

              base.OnModelCreating(modelBuilder);
        }
    }
}
