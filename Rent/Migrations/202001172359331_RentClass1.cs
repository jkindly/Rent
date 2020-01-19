namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentClass1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rents", "CarId", "dbo.Cars");
            DropIndex("dbo.Rents", new[] { "CarId" });
            AddColumn("dbo.Cars", "Rent_Id", c => c.Int());
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Segment", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "ProductionYear", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "FuelType", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "VIN", c => c.String(nullable: false));
            CreateIndex("dbo.Cars", "Rent_Id");
            AddForeignKey("dbo.Cars", "Rent_Id", "dbo.Rents", "Id");
            DropColumn("dbo.Rents", "CarId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rents", "CarId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cars", "Rent_Id", "dbo.Rents");
            DropIndex("dbo.Cars", new[] { "Rent_Id" });
            AlterColumn("dbo.Cars", "VIN", c => c.String());
            AlterColumn("dbo.Cars", "FuelType", c => c.String());
            AlterColumn("dbo.Cars", "ProductionYear", c => c.String());
            AlterColumn("dbo.Cars", "Segment", c => c.String());
            AlterColumn("dbo.Cars", "Model", c => c.String());
            DropColumn("dbo.Cars", "Rent_Id");
            CreateIndex("dbo.Rents", "CarId");
            AddForeignKey("dbo.Rents", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
        }
    }
}
