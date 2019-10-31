using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class quest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b4d74ab6-106a-4746-98a8-497a00e9fe44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "721b5e48-3680-41ce-a954-e222ee76cab8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f7e83811-df6c-4889-8629-0e0007627a96");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "e3b33831-207c-42d6-bcdf-f0111d3f3226");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "PostID", "AccountID", "CategoryID", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "1", 1, null, "When U go to restaurants will they start charging u service charge & plus tip ?" },
                    { 2, "2", 3, null, "Why does McDonald's taste so bad?" },
                    { 3, "3", 4, "She gave me the wrong change", "Why couldn't she give me different change? was she dumb?" },
                    { 4, "4", 3, "They look the same", "What is the difference between subway and quiznos?" },
                    { 5, "5", 8, "Since it discriminates on the basis of race.", "Isn’t affirmative action a violation of the civil rights act?" },
                    { 6, "1", 9, "Seriously, if you want to get a job that pays above minimum wage, get some job training like medical assisting or dental assisting.", "Why do people want to raise the minimum wage?" },
                    { 7, "2", 1, "I need answers.", "Why havent we landed on the sun?" },
                    { 8, "3", 2, "What you find tastiest - fish, salmon, shrimps, shellfish, chicken, turkey, pork, bacon, sausage, beef???", "What is the tastiest meat according to you?" },
                    { 9, "4", 6, null, "If you vote Democrat, are you telling the world you are pro-communist?" },
                    { 10, "5", 7, null, "My kid's school want to take them on a field trip to a windmill farm, but what about windmill cancer?" },
                    { 11, "5", 9, "What is the most endangered island in the world?", "What is the most endangered island in the world?" }
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
                value: "3efb2843-2839-4730-a120-aba7f9a4323e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bf573fd7-1b99-4006-8bf3-38964a8a884b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a0d46d41-9fcd-492e-b239-71117cfc478b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "fd6c2a63-63dd-429b-b827-fed48f39ef18");
        }
    }
}
