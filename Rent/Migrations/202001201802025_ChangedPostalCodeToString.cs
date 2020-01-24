namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPostalCodeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PostalCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PostalCode", c => c.Int(nullable: false));
        }
    }
}
