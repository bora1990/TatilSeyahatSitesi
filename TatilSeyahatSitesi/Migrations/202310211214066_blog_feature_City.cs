﻿namespace TatilSeyahatSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blog_feature_City : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "City");
        }
    }
}
