namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, MembershipFee, DurationInMonths, DiscountRate)" +
                "VALUES (2, 8, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, MembershipFee, DurationInMonths, DiscountRate)" +
                "VALUES (3, 20, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, MembershipFee, DurationInMonths, DiscountRate)" +
                "VALUES (4, 65, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
