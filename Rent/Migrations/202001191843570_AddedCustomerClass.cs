namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Pesel = c.Int(nullable: false),
                        IdNumber = c.String(nullable: false),
                        IdDriver = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
