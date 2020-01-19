namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentStarTime = c.DateTime(nullable: false),
                        RentEndTime = c.DateTime(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "CarId", "dbo.Cars");
            DropIndex("dbo.Rents", new[] { "CarId" });
            DropTable("dbo.Rents");
        }
    }
}
