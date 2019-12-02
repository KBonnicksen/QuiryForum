using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class catColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a4717222-90cf-42b6-ae68-df9943f213dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "23e61b2b-ab3c-4a0a-a956-6c41ebb03f85");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "01d81fc0-d5de-449f-a389-9c14c99b1457");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "cc3b063c-3a81-4076-8cec-2f3e6d158c1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "9e92b75a-fda5-4435-816d-425dc69e4f29");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f573b4cc-d23f-461b-a4e0-d5553f0386e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9cc37655-85ae-44c6-86d6-155df363b561");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "421f103f-3533-4887-8057-29de5aa3cd4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2cc94af8-82ff-4f70-8b38-700ad4f94ac4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "29a12b5a-9247-42ef-885a-86adb1ea2208");
        }
    }
}
