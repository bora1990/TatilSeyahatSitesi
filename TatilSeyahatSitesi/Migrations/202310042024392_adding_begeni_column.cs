namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_begeni_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BegeniPuani", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BegeniPuani");
        }
    }
}
