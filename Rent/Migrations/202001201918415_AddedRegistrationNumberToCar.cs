namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRegistrationNumberToCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "RegistrationNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "RegistrationNumber");
        }
    }
}
