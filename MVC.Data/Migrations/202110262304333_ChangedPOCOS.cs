namespace MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPOCOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Player", "OwnerId");
        }
    }
}
