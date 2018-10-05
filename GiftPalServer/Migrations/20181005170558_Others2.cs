using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class Others2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Users_UsersId",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_UsersId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Goods");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_UserId",
                table: "Goods",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Users_UserId",
                table: "Goods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Users_UserId",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_UserId",
                table: "Goods");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Goods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goods_UsersId",
                table: "Goods",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Users_UsersId",
                table: "Goods",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
