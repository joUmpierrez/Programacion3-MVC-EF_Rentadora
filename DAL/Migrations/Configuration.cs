namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.RentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.RentalContext context)
        {


        }
    }
}
