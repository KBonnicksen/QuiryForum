using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class wholeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "900da9d0-af32-40a6-935d-9b63c3053498");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d411d45f-94c0-4d13-b05b-cb3eaea9e1ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3b74c6ad-4925-46f7-8c37-57545a21e0c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d6e9e733-0c34-4345-92c1-d486e9c9046c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "fbd483d8-1a25-4d9a-8855-a62685dccd6b");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryID",
                table: "Questions",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions");

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
    }
}
