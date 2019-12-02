using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class QCatTOQCatName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Questions",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4106e998-76c6-413d-aed6-f352c3ba1eb1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bf63588d-f94b-4d3b-a1c4-881dc5c0306d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b255c272-6b93-4fb3-8d62-d2e6879d6c92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "aed1368f-797b-4add-8dbe-29b7d039da93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "19fcbf4f-61e1-4509-a748-0c639eabdce2");

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
    }
}
