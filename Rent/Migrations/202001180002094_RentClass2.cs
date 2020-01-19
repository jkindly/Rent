namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentClass2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Rent_Id", "dbo.Rents");
            DropIndex("dbo.Cars", new[] { "Rent_Id" });
            RenameColumn(table: "dbo.Cars", name: "Rent_Id", newName: "RentId");
            AlterColumn("dbo.Cars", "RentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "RentId");
            AddForeignKey("dbo.Cars", "RentId", "dbo.Rents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "RentId", "dbo.Rents");
            DropIndex("dbo.Cars", new[] { "RentId" });
            AlterColumn("dbo.Cars", "RentId", c => c.Int());
            RenameColumn(table: "dbo.Cars", name: "RentId", newName: "Rent_Id");
            CreateIndex("dbo.Cars", "Rent_Id");
            AddForeignKey("dbo.Cars", "Rent_Id", "dbo.Rents", "Id");
        }
    }
}
