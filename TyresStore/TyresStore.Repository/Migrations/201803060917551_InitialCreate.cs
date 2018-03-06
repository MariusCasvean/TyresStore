namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tyre",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehicleId = c.Int(nullable: false),
                        Brand = c.String(),
                        Season = c.String(),
                        ArticleCode = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Color = c.String(),
                        Price = c.Int(nullable: false),
                        Power = c.String(),
                        SpeedLimit = c.String(),
                        Transmission = c.String(),
                        Consumption = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tyre", "VehicleId", "dbo.Vehicle");
            DropIndex("dbo.Tyre", new[] { "VehicleId" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.Tyre");
        }
    }
}
