using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Data.Migrations
{
    public partial class ac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_FollowerId",
                table: "AccountFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_UserId",
                table: "AccountFollowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountFollowers_UserId",
                table: "AccountFollowers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AccountFollowers");

            migrationBuilder.DropColumn(
                name: "FollowerID",
                table: "AccountFollowers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AccountFollowers",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "FollowerId",
                table: "AccountFollowers",
                newName: "FollowerID");

            migrationBuilder.RenameIndex(
                name: "IX_AccountFollowers_FollowerId",
                table: "AccountFollowers",
                newName: "IX_AccountFollowers_FollowerID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "AccountFollowers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FollowerID",
                table: "AccountFollowers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers",
                columns: new[] { "UserID", "FollowerID" });

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_FollowerID",
                table: "AccountFollowers",
                column: "FollowerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_UserID",
                table: "AccountFollowers",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_FollowerID",
                table: "AccountFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_UserID",
                table: "AccountFollowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers");

            migrationBuilder.RenameColumn(
                name: "FollowerID",
                table: "AccountFollowers",
                newName: "FollowerId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "AccountFollowers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountFollowers_FollowerID",
                table: "AccountFollowers",
                newName: "IX_AccountFollowers_FollowerId");

            migrationBuilder.AlterColumn<string>(
                name: "FollowerId",
                table: "AccountFollowers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AccountFollowers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "AccountFollowers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FollowerID",
                table: "AccountFollowers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers",
                columns: new[] { "UserID", "FollowerID" });

            migrationBuilder.CreateIndex(
                name: "IX_AccountFollowers_UserId",
                table: "AccountFollowers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_FollowerId",
                table: "AccountFollowers",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_UserId",
                table: "AccountFollowers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
