namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeyNotNullRentIdToCarClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "RentId", "dbo.Rents");
            DropIndex("dbo.Cars", new[] { "RentId" });
            AlterColumn("dbo.Cars", "RentId", c => c.Int());
            CreateIndex("dbo.Cars", "RentId");
            AddForeignKey("dbo.Cars", "RentId", "dbo.Rents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "RentId", "dbo.Rents");
            DropIndex("dbo.Cars", new[] { "RentId" });
            AlterColumn("dbo.Cars", "RentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "RentId");
            AddForeignKey("dbo.Cars", "RentId", "dbo.Rents", "Id", cascadeDelete: true);
        }
    }
}
