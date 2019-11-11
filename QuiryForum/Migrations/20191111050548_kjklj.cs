using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Migrations
{
    public partial class kjklj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionPostID",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Questions",
                newName: "QuestionID");

            migrationBuilder.RenameColumn(
                name: "QuestionPostID",
                table: "Answers",
                newName: "QuestionID1");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Answers",
                newName: "AnswerID");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionPostID",
                table: "Answers",
                newName: "IX_Answers_QuestionID1");

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7a49806-9bff-4a1b-bd93-6af29f7a6368");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5b464eeb-af4d-4cdc-a179-04d45e171782");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cec88767-f60a-45fb-b968-004ef51a9817");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "25bf630b-d956-450f-84c9-c8d6cf19dc2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "98ea9e18-3975-4325-9b4c-3a8d269162af");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                table: "Answers",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "QuestionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionID1",
                table: "Answers",
                column: "QuestionID1",
                principalTable: "Questions",
                principalColumn: "QuestionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionID1",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Questions",
                newName: "PostID");

            migrationBuilder.RenameColumn(
                name: "QuestionID1",
                table: "Answers",
                newName: "QuestionPostID");

            migrationBuilder.RenameColumn(
                name: "AnswerID",
                table: "Answers",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionID1",
                table: "Answers",
                newName: "IX_Answers_QuestionPostID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3a0cfdac-8edd-4296-b444-578d1b16ce2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f5b2ad67-16b6-40ae-b1f5-cb9c81c6ec75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c6f5722e-e550-43cb-8694-d6b8df2961ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3168b55b-7b8e-4390-8d9c-d5936ca8a147");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "0b94c509-3f7e-4c1a-90e9-6dc22ae45d0a");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionPostID",
                table: "Answers",
                column: "QuestionPostID",
                principalTable: "Questions",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
