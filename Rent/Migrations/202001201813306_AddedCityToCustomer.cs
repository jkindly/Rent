namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCityToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "City");
        }
    }
}
