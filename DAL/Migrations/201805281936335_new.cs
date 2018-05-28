namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        costPerDay = c.Double(nullable: false),
                        numPassengers = c.Int(),
                        type = c.String(),
                        brand = c.String(),
                        model = c.String(),
                        competitorCode = c.String(),
                        numDoors = c.Int(),
                        type1 = c.String(),
                        brand1 = c.String(),
                        model1 = c.String(),
                        color = c.String(),
                        chasisNum = c.Int(),
                        motorNum = c.Int(),
                        registerNum = c.String(),
                        numRooms = c.Int(),
                        numBathrooms = c.Int(),
                        buildSurface = c.Int(),
                        address = c.String(),
                        city = c.String(),
                        pool = c.Boolean(),
                        garage = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
                        idCard = c.Int(),
                        employeeNum = c.Int(),
                        password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
                .ForeignKey("dbo.People", t => t.client_id)
                .ForeignKey("dbo.People", t => t.employee_id)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceLines", "Invoice_id", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceLines", "rent_id", "dbo.Rents");
            DropForeignKey("dbo.Rents", "service_id", "dbo.Services");
            DropForeignKey("dbo.Rents", "employee_id", "dbo.People");
            DropForeignKey("dbo.Rents", "client_id", "dbo.People");
            DropIndex("dbo.Rents", new[] { "service_id" });
            DropIndex("dbo.Rents", new[] { "employee_id" });
            DropIndex("dbo.Rents", new[] { "client_id" });
            DropIndex("dbo.InvoiceLines", new[] { "Invoice_id" });
            DropIndex("dbo.InvoiceLines", new[] { "rent_id" });
            DropTable("dbo.Invoices");
            DropTable("dbo.Rents");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.People");
            DropTable("dbo.Services");
        }
    }
}
