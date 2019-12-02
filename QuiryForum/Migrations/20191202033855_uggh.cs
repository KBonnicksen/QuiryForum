using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class uggh : Migration
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
                name: "Icon",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ce4dd9e9-a5e2-4b9d-a160-3b146e4afeb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c99d8d01-266c-4dc9-b396-4994b18f15b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a49855c6-7929-4148-a588-0169e86ca231");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "eb1ed840-2e87-4a47-868c-4f63ecd7096f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "b44cc59e-5e29-4e3d-a6fe-034b67f9e2bd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Categories");

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
    }
}
