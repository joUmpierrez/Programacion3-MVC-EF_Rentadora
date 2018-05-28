namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        costPerDay = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        lastname = c.String(nullable: false),
                        telephoneNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InvoiceLines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false),
                        quantity = c.Int(nullable: false),
                        cost = c.Double(nullable: false),
                        rent_id = c.Int(nullable: false),
                        Invoice_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Rents", t => t.rent_id, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.Invoice_id)
                .Index(t => t.rent_id)
                .Index(t => t.Invoice_id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        client_id = c.Int(nullable: false),
                        employee_id = c.Int(nullable: false),
                        service_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clients", t => t.client_id)
                .ForeignKey("dbo.Employees", t => t.employee_id)
                .ForeignKey("dbo.Services", t => t.service_id, cascadeDelete: true)
                .Index(t => t.client_id)
                .Index(t => t.employee_id)
                .Index(t => t.service_id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        rut = c.Int(nullable: false),
                        name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        id = c.Int(nullable: false),
                        numPassengers = c.Int(nullable: false),
                        type = c.String(nullable: false),
                        brand = c.String(nullable: false),
                        model = c.String(nullable: false),
                        competitorCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Services", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.Int(nullable: false),
                        numDoors = c.Int(nullable: false),
                        type = c.String(nullable: false),
                        brand = c.String(nullable: false),
                        model = c.String(nullable: false),
                        color = c.String(nullable: false),
                        chasisNum = c.Int(nullable: false),
                        motorNum = c.Int(nullable: false),
                        registerNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Services", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false),
                        idCard = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false),
                        employeeNum = c.Int(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.People", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        id = c.Int(nullable: false),
                        numRooms = c.Int(nullable: false),
                        numBathrooms = c.Int(nullable: false),
                        buildSurface = c.Int(nullable: false),
                        address = c.String(nullable: false),
                        city = c.String(nullable: false),
                        pool = c.Boolean(nullable: false),
                        garage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Services", t => t.id)
                .Index(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "id", "dbo.Services");
            DropForeignKey("dbo.Employees", "id", "dbo.People");
            DropForeignKey("dbo.Clients", "id", "dbo.People");
            DropForeignKey("dbo.Cars", "id", "dbo.Services");
            DropForeignKey("dbo.Boats", "id", "dbo.Services");
            DropForeignKey("dbo.InvoiceLines", "Invoice_id", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceLines", "rent_id", "dbo.Rents");
            DropForeignKey("dbo.Rents", "service_id", "dbo.Services");
            DropForeignKey("dbo.Rents", "employee_id", "dbo.Employees");
            DropForeignKey("dbo.Rents", "client_id", "dbo.Clients");
            DropIndex("dbo.Houses", new[] { "id" });
            DropIndex("dbo.Employees", new[] { "id" });
            DropIndex("dbo.Clients", new[] { "id" });
            DropIndex("dbo.Cars", new[] { "id" });
            DropIndex("dbo.Boats", new[] { "id" });
            DropIndex("dbo.Rents", new[] { "service_id" });
            DropIndex("dbo.Rents", new[] { "employee_id" });
            DropIndex("dbo.Rents", new[] { "client_id" });
            DropIndex("dbo.InvoiceLines", new[] { "Invoice_id" });
            DropIndex("dbo.InvoiceLines", new[] { "rent_id" });
            DropTable("dbo.Houses");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
            DropTable("dbo.Boats");
            DropTable("dbo.Invoices");
            DropTable("dbo.Rents");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.People");
            DropTable("dbo.Services");
        }
    }
}
