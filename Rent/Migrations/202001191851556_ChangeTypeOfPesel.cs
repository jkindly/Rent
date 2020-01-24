namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfPesel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Pesel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Pesel", c => c.Int(nullable: false));
        }
    }
}
