namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_relation_otel_oteldetay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OtelDetays",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Resim1 = c.String(),
                        Resim2 = c.String(),
                        Resim3 = c.String(),
                        OtelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.OtelID, cascadeDelete: true)
                .Index(t => t.OtelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OtelDetays", "OtelID", "dbo.Otels");
            DropIndex("dbo.OtelDetays", new[] { "OtelID" });
            DropTable("dbo.OtelDetays");
        }
    }
}
