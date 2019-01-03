namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGameReleaseDateAndStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Games", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "NumberInStock");
            DropColumn("dbo.Games", "ReleaseDate");
        }
    }
}
