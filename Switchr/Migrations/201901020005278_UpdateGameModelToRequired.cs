namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGameModelToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "ReleaseDate", c => c.DateTime());
        }
    }
}
