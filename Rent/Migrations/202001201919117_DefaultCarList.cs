namespace Rent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultCarList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('EL2321D', 'Suzuki', 'Baleno', 'B', 2019, 'PB', '1XP5DU9X2YN517816', 2311, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('EL2922E', 'Suzuki', 'Swift', 'B', 2018, 'PB', '5GZCZ63434S801406', 41222, 0)");
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('GA332EP', 'Volkswagen', 'Golf', 'C', 2019, 'PB', '1FTWW31P07EB26815', 8964, 0)"); 
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('WL7223L', 'Fiat', 'Tipo', 'C+', 2018, 'PB', '3GCEC14X56G296843', 12932, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('GA638CT', 'Opel', 'Insignia', 'D', 2019, 'ON', 'KNAFE121875491399', 18922, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('GA810AW', 'Mazda', '6', 'DPrem', 2019, 'PB', '1ZWFT61L0Y5691499', 9988, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('LU325GA', 'Volkswagen', 'Passat', 'DPrem', 2019, 'ON', '4T1BG22K8XU592261', 21223, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('LU911WY', 'Audi', 'A5', 'S', 2020, 'PB', '1G2ZG558064243957', 890, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('WJ8681F', 'Fiat', 'Ducato', 'P+', 2019, 'ON', '1GCEC19XX4Z345461', 32229, 0)");            
            Sql("INSERT INTO Cars(RegistrationNumber, Brand, Model, Segment, ProductionYear, FuelType, VIN, Odometer, IsRent) " +
                "VALUES ('EL4N833', 'Fiat', 'Ducato', 'N', 2019, 'ON', '1FT8W3DT8CEA48103', 29846, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
