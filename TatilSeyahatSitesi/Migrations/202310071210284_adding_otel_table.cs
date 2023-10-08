namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_otel_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OtelAdi = c.String(),
                        OtelImage = c.String(),
                        BlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blogs", t => t.BlogID, cascadeDelete: true)
                .Index(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Otels", "BlogID", "dbo.Blogs");
            DropIndex("dbo.Otels", new[] { "BlogID" });
            DropTable("dbo.Otels");
        }
    }
}
