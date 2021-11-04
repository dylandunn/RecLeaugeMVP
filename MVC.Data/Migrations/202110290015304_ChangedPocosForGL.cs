namespace MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPocosForGL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameLog",
                c => new
                    {
                        GameLogId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        DateOfGame = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GameLogId)
                .ForeignKey("dbo.Player", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
            AddColumn("dbo.Player", "PointsPerGame", c => c.Double(nullable: false));
            AlterColumn("dbo.Player", "AssistsPerGame", c => c.Double(nullable: false));
            AlterColumn("dbo.Player", "ReboundsPerGame", c => c.Double(nullable: false));
            AlterColumn("dbo.Player", "BlocksPerGame", c => c.Double(nullable: false));
            AlterColumn("dbo.Player", "StealsPerGame", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameLog", "PlayerId", "dbo.Player");
            DropIndex("dbo.GameLog", new[] { "PlayerId" });
            AlterColumn("dbo.Player", "StealsPerGame", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Player", "BlocksPerGame", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Player", "ReboundsPerGame", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Player", "AssistsPerGame", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Player", "PointsPerGame");
            DropTable("dbo.GameLog");
        }
    }
}
