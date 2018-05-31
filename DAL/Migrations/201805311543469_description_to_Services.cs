namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description_to_Services : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "description");
        }
    }
}
