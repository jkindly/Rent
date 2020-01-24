namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCarAndCustomerToRentCarModel : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE [Cars] DROP CONSTRAINT [FK_dbo.Cars_dbo.Rents_RentId]");
            DropForeignKey("dbo.Cars", "RentId", "dbo.RentCars");
            DropIndex("dbo.Cars", new[] { "RentId" });
            AddColumn("dbo.RentCars", "CustomerId", c => c.Int());
            AddColumn("dbo.RentCars", "CarId", c => c.Int());
            CreateIndex("dbo.RentCars", "CustomerId");
            CreateIndex("dbo.RentCars", "CarId");
            AddForeignKey("dbo.RentCars", "CarId", "dbo.Cars", "Id");
            AddForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers", "Id");
            DropColumn("dbo.Cars", "RentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "RentId", c => c.Int());
            DropForeignKey("dbo.RentCars", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RentCars", "CarId", "dbo.Cars");
            DropIndex("dbo.RentCars", new[] { "CarId" });
            DropIndex("dbo.RentCars", new[] { "CustomerId" });
            DropColumn("dbo.RentCars", "CarId");
            DropColumn("dbo.RentCars", "CustomerId");
            CreateIndex("dbo.Cars", "RentId");
            AddForeignKey("dbo.Cars", "RentId", "dbo.RentCars", "Id");
        }
    }
}
