using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class UserRelUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserRelations_DestinationId",
                table: "UserRelations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelations_SourceId",
                table: "UserRelations",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelations_Users_DestinationId",
                table: "UserRelations",
                column: "DestinationId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelations_Users_SourceId",
                table: "UserRelations",
                column: "SourceId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelations_Users_DestinationId",
                table: "UserRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRelations_Users_SourceId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_UserRelations_DestinationId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_UserRelations_SourceId",
                table: "UserRelations");
        }
    }
}
