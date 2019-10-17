using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Data.Migrations
{
    public partial class acc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          //  migrationBuilder.DropForeignKey(
          //      name: "FK_AccountFollowers_Accounts_FollowerID",
           //     table: "AccountFollowers");

           // migrationBuilder.DropForeignKey(
          //      name: "FK_AccountFollowers_Accounts_UserID",
          //      table: "AccountFollowers");

         //   migrationBuilder.DropForeignKey(
          //      name: "FK_Posts_Accounts_AccountID",
          //      table: "Posts");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Posts",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AccountID",
                table: "Posts",
                newName: "IX_Posts_AccountId");

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
                name: "AccountId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FollowerId",
                table: "AccountFollowers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AccountFollowers",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AccountId",
                table: "Posts",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_FollowerId",
                table: "AccountFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_AspNetUsers_UserId",
                table: "AccountFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AccountId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountFollowers_UserId",
                table: "AccountFollowers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AccountFollowers");

            migrationBuilder.DropColumn(
                name: "FollowerID",
                table: "AccountFollowers");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Posts",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AccountId",
                table: "Posts",
                newName: "IX_Posts_AccountID");

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

            migrationBuilder.AlterColumn<int>(
                name: "AccountID",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "AccountFollowers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FollowerID",
                table: "AccountFollowers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountFollowers",
                table: "AccountFollowers",
                columns: new[] { "UserID", "FollowerID" });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    IsPrivate = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_Accounts_FollowerID",
                table: "AccountFollowers",
                column: "FollowerID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_Accounts_UserID",
                table: "AccountFollowers",
                column: "UserID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Accounts_AccountID",
                table: "Posts",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
