namespace GameWatcher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26mar2015 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "ChannelId", "dbo.Channels");
            DropIndex("dbo.Games", new[] { "ChannelId" });
            AlterColumn("dbo.Games", "ChannelId", c => c.Int());
            CreateIndex("dbo.Games", "ChannelId");
            AddForeignKey("dbo.Games", "ChannelId", "dbo.Channels", "ChannelId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ChannelId", "dbo.Channels");
            DropIndex("dbo.Games", new[] { "ChannelId" });
            AlterColumn("dbo.Games", "ChannelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "ChannelId");
            AddForeignKey("dbo.Games", "ChannelId", "dbo.Channels", "ChannelId", cascadeDelete: true);
        }
    }
}
