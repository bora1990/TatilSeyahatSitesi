namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_feature_otelAciklama : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otels", "OtelAciklama", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Otels", "OtelAciklama");
        }
    }
}
