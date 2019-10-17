using Microsoft.EntityFrameworkCore.Migrations;

namespace QuiryForum.Data.Migrations
{
    public partial class FKConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_Accounts_UserAccountID",
                table: "AccountFollowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountFollowers_UserAccountID",
                table: "AccountFollowers");

            migrationBuilder.DropColumn(
                name: "UserAccountID",
                table: "AccountFollowers");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AccountFollowers_Accounts_UserID",
            //    table: "AccountFollowers",
            //    column: "UserID",
            //    principalTable: "Accounts",
            //    principalColumn: "AccountID",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountFollowers_Accounts_UserID",
                table: "AccountFollowers");

            migrationBuilder.AddColumn<int>(
                name: "UserAccountID",
                table: "AccountFollowers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountFollowers_UserAccountID",
                table: "AccountFollowers",
                column: "UserAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountFollowers_Accounts_UserAccountID",
                table: "AccountFollowers",
                column: "UserAccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
