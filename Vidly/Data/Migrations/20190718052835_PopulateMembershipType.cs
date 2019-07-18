using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class PopulateMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
               table: "MemberShipType",
               columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate" },
               values: new object[] { 1, 0, 0, 0});

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate" },
              values: new object[] { 2, 30, 1, 10 });

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate" },
              values: new object[] { 3,90, 3, 15 });

            migrationBuilder.InsertData(
              table: "MemberShipType",
              columns: new[] { "Id", "SignUpFree", "DrationInMonth", "DiscountRate" },
              values: new object[] { 4, 300, 12, 20 });

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "MemberShipType",
               keyColumn: "Id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberShipType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MemberShipType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MemberShipType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
