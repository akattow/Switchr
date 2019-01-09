namespace Switchr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'025610fb-63bc-4f6a-b5f8-5708cf01b7ad', N'guest@switchr.com', 0, N'AM4bMtHVMqlq6CQNcRmFfdS9g56LD3f5CQYFuBjp9/k/DFuAM1O/AQeRBtIV5QImiw==', N'2e39abb6-4eb2-451d-8895-b7bed7800813', NULL, 0, 0, NULL, 1, 0, N'guest@switchr.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3c19dd3-e022-438e-a2af-b70aed99f470', N'admin@switchr.com', 0, N'AJwlb/eOMOdmy1BV+S7k2t145175PZInh4zwGsDBrqQiUrdFzgRAL2OATX+tLNu3FQ==', N'7cc8e715-6145-4a2b-a64f-450345557841', NULL, 0, 0, NULL, 1, 0, N'admin@switchr.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c5970644-c8d4-40ad-bfc8-b4553d3c2386', N'CanManageGames')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c3c19dd3-e022-438e-a2af-b70aed99f470', N'c5970644-c8d4-40ad-bfc8-b4553d3c2386')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
