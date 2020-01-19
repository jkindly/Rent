namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCarPropertiesType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Brand", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Cars", "Segment", c => c.String());
            AlterColumn("dbo.Cars", "ProductionYear", c => c.String());
            AlterColumn("dbo.Cars", "FuelType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "FuelType", c => c.Byte(nullable: false));
            AlterColumn("dbo.Cars", "ProductionYear", c => c.Byte(nullable: false));
            AlterColumn("dbo.Cars", "Segment", c => c.Byte(nullable: false));
            AlterColumn("dbo.Cars", "Brand", c => c.String());
        }
    }
}
