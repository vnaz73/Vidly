using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class AddNameToMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                nullable: true);

            migrationBuilder.Sql("DELETE FROM MembershipType");

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate", "Name" },
              values: new object[] { 1, 0, 0, 0 , "-"});

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate", "Name" },
              values: new object[] { 2, 30, 1, 10, "month" });

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate", "Name" },
              values: new object[] { 3, 90, 3, 15, "quoter" });

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate", "Name" },
              values: new object[] { 4, 300, 12, 20, "year" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");
        }
    }
}
