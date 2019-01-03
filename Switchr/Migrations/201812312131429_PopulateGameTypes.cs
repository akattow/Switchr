namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (1, 'Fighting')");
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (2, 'Role-Playing Game')");
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (3, 'Massive Multiplayer Online')");
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (4, 'Sports')");
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (5, 'Educational')");
            Sql("INSERT INTO GameTypes (Id, Name)" +
                "VALUES (6, 'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
