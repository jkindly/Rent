namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHouseNumberToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "HouseNumber", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "HouseNumber");
        }
    }
}
