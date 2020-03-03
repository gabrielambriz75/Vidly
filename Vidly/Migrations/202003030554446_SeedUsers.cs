namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51cf17ca-b65b-495c-93c9-262cc7c94b2c', N'admin@vidly.com', 0, N'ANnz2t+BVuFe4ZD6S9NLRAD/J18dPtw3RJr6JxNYxDAb4Hqzh5Bx3DF/go5oOYPMwA==', N'd56ca840-68cc-4d33-a4f2-9d47134018ac', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6cca7e49-0575-4ce7-9ce2-aa709609371e', N'guest@vidly.com', 0, N'AKH9uhPkxYT/y5pNH9to7KjzLFNLmaNicRNa+vWHIrux/0kLEhmTR0Wi2TneIdVeEA==', N'40c74436-5b6b-463a-9f17-e90d9ce94bb0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'522e440d-802c-422a-8ea3-994f946e8bc2', N'CanManageMovies')
        INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'51cf17ca-b65b-495c-93c9-262cc7c94b2c', N'522e440d-802c-422a-8ea3-994f946e8bc2')"
        );

        }

        public override void Down()
        {
        }
    }
}
