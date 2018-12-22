namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7cc3eb7b-d0cc-4d61-9810-866e07d6325b', N'admin@videostore.com', 0, N'AIqYW3b/hlJAP6030Meu9PgFEgOccb29VUpbU6r8kHp1+JeWxEBLen5iHbEsncMqyA==', N'b0cd6d2d-f89f-442c-848e-a2e473950741', NULL, 0, 0, NULL, 1, 0, N'admin@videostore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4327550-0b98-4928-be6d-7b1d477a087b', N'guest@videostore.com', 0, N'ABmryLZELNX+TQntIjZx0iHY5MM9KZ6sJjBHRjVcyiGoIi19qP/VKXt8d0AnN6bRmQ==', N'1c7bd3f3-df5d-4605-8228-951fdf10c2b3', NULL, 0, 0, NULL, 1, 0, N'guest@videostore.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'595276ee-33eb-468f-81ea-cc772cb6791b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7cc3eb7b-d0cc-4d61-9810-866e07d6325b', N'595276ee-33eb-468f-81ea-cc772cb6791b')

");
        }
        
        public override void Down()
        {
        }
    }
}
