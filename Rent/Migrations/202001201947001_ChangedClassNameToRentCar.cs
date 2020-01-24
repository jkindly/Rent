namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedClassNameToRentCar : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Rents", newName: "RentCars");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.RentCars", newName: "Rents");
        }
    }
}
