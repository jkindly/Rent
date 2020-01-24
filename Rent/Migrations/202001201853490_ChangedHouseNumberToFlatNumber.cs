namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedHouseNumberToFlatNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FlatNumber", c => c.Int());
            DropColumn("dbo.Customers", "HouseNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "HouseNumber", c => c.Int());
            DropColumn("dbo.Customers", "FlatNumber");
        }
    }
}
