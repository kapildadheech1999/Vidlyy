namespace Vidlyy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicence]) VALUES (N'2f22a7cd-bd39-402a-9744-887f8602ea02', N'rohit@gmail.com', 0, N'AD66q1eRxwLoiYBGpu4hWWpVy1lDzHF9VUswVgO2th45mll/vepu5Qta/r617i3fTQ==', N'36a124aa-f365-4115-bef4-0a44dd426db0', NULL, 0, 0, NULL, 1, 0, N'rohit@gmail.com', N'1234')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicence]) VALUES (N'88c75703-3da1-416d-96e3-696bc28828ce', N'Kamil.monu@gmail.com', 0, N'ANcCbRcmClWmsiDPTMrTMqbWAlvHnxX8UvTU7tvZtD2oYxC5cx0fiEExDW7i1iihug==', N'6d8fef0c-5f28-4937-8328-4b89d5d74ab2', NULL, 0, 0, NULL, 1, 0, N'Kamil.monu@gmail.com', N'1234')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9b95bbe0-f887-4e9a-9935-9682d7b70816', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2f22a7cd-bd39-402a-9744-887f8602ea02', N'9b95bbe0-f887-4e9a-9935-9682d7b70816')
                  ");
        }

        public override void Down()
        {
        }
    }
}
