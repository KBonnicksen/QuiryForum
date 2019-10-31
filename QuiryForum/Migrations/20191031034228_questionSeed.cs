using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class questionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f8a07d30-241b-4983-b1f3-7b1fe7260001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2424f8fd-94d6-4bf5-967c-d13a40b8d2c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4b42f746-4af0-410c-b04f-90afa353751e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3c379962-24d4-4e6c-81b3-5a9a302872d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "9254de0b-8603-42ad-a25e-79ac4f5cb719");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "PostID", "CategoryID", "Content", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "When U go to restaurants will they start charging u service charge & plus tip ?", "1" },
                    { 2, 3, null, "Why does McDonald's taste so bad?", "2" },
                    { 3, 4, "She gave me the wrong change", "Why couldn't she give me different change? was she dumb?", "3" },
                    { 4, 3, "They look the same", "What is the difference between subway and quiznos?", "4" },
                    { 5, 8, "Since it discriminates on the basis of race.", "Isn’t affirmative action a violation of the civil rights act?", "5" },
                    { 6, 9, "Seriously, if you want to get a job that pays above minimum wage, get some job training like medical assisting or dental assisting.", "Why do people want to raise the minimum wage?", "1" },
                    { 7, 1, "I need answers.", "Why havent we landed on the sun?", "2" },
                    { 8, 2, "What you find tastiest - fish, salmon, shrimps, shellfish, chicken, turkey, pork, bacon, sausage, beef???", "What is the tastiest meat according to you?", "3" },
                    { 9, 6, null, "If you vote Democrat, are you telling the world you are pro-communist?", "4" },
                    { 10, 7, null, "My kid's school want to take them on a field trip to a windmill farm, but what about windmill cancer?", "5" },
                    { 11, 9, "What is the most endangered island in the world?", "What is the most endangered island in the world?", "5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "PostID",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "063d2614-6ee2-4f49-bef2-431eb2917d98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9a4b145c-0487-494b-9785-39271fa7fffe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "dc2f5865-b055-49e1-a121-aecbf107cd37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d97168db-fe83-4811-8b4e-851bb95c11f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "c16eeca6-6203-4d50-9743-c62369baa850");
        }
    }
}
