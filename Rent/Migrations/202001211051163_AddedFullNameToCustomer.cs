namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFullNameToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "FullName");
        }
    }
}
