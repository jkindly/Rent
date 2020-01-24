namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredCarAndCustomerInRentCar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentCars", "CarId", "dbo.Cars");
            DropForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers");
            DropIndex("dbo.RentCars", new[] { "CustomerId" });
            DropIndex("dbo.RentCars", new[] { "CarId" });
            AlterColumn("dbo.RentCars", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.RentCars", "CarId", c => c.Int(nullable: false));
            CreateIndex("dbo.RentCars", "CustomerId");
            CreateIndex("dbo.RentCars", "CarId");
            AddForeignKey("dbo.RentCars", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RentCars", "CarId", "dbo.Cars");
            DropIndex("dbo.RentCars", new[] { "CarId" });
            DropIndex("dbo.RentCars", new[] { "CustomerId" });
            AlterColumn("dbo.RentCars", "CarId", c => c.Int());
            AlterColumn("dbo.RentCars", "CustomerId", c => c.Int());
            CreateIndex("dbo.RentCars", "CarId");
            CreateIndex("dbo.RentCars", "CustomerId");
            AddForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers", "Id");
            AddForeignKey("dbo.RentCars", "CarId", "dbo.Cars", "Id");
        }
    }
}
