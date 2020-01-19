namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsRentToCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "IsRent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "IsRent");
        }
    }
}
