namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotateGames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Name", c => c.String());
        }
    }
}
