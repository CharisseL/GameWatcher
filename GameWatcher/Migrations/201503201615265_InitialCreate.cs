namespace GameWatcher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        ChannelId = c.Int(nullable: false, identity: true),
                        ChannelName = c.String(),
                    })
                .PrimaryKey(t => t.ChannelId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        AwayTeam = c.String(),
                        HomeTeam = c.String(),
                        AwayScore = c.Int(nullable: false),
                        HomeScore = c.Int(nullable: false),
                        ChannelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Channels", t => t.ChannelId, cascadeDelete: true)
                .Index(t => t.ChannelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ChannelId", "dbo.Channels");
            DropIndex("dbo.Games", new[] { "ChannelId" });
            DropTable("dbo.Games");
            DropTable("dbo.Channels");
        }
    }
}
