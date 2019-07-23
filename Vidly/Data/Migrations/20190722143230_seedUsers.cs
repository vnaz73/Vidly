using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("" +
                "INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'21a06cb2-aeef-4fc7-88d5-3b9a08fddcee', N'guest@vidly.com', N'GUEST@VIDLY.COM', N'guest@vidly.com', N'GUEST@VIDLY.COM', 0, N'AQAAAAEAACcQAAAAEEHf/P58Zn8W1RHSLmrv4EevyE4CfhIewgH1StffGPS8b+I+AdeuDU7AfamWtO9LBw==', N'LY44DSUZXV7MXJ4I5UG4XPOXDMNEMOEW', N'78175106-0cfc-4d1e-a494-f16fdedba9d2', NULL, 0, 0, NULL, 1, 0); " +
                "INSERT INTO[dbo].[AspNetUsers]([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES(N'779b6a06-2dec-461f-8a23-ff334d7b895b', N'admin@vidly.com', N'ADMIN@VIDLY.COM', N'admin@vidly.com', N'ADMIN@VIDLY.COM', 0, N'AQAAAAEAACcQAAAAEO8XKmrkiK74X7cu2XwoM6pB2kcO5uVqzjLAMZqhC4ilDBc2JEOWCrZLY+ss/EPO6g==', N'J7EUMHI5C36MRVFAXD6YQPIMKUADF2R2', N'f10fb11a-24c0-4fd6-bd98-11291b515a8b', NULL, 0, 0, NULL, 1, 0); "+

              "INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3ca872e0-50af-49fd-b33d-fc486b119da3', N'CanManageMovie', N'CANMANAGEMOVIE', N'31b484be-1ea7-4bf5-8d19-57f3f74db8d8')") ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
