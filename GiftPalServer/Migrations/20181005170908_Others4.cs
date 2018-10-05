using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class Others4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelations_Goods_GoodsId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_UserRelations_GoodsId",
                table: "UserRelations");

            migrationBuilder.DropColumn(
                name: "GoodsId",
                table: "UserRelations");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelations_GoodId",
                table: "UserRelations",
                column: "GoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelations_Goods_GoodId",
                table: "UserRelations",
                column: "GoodId",
                principalTable: "Goods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelations_Goods_GoodId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_UserRelations_GoodId",
                table: "UserRelations");

            migrationBuilder.AddColumn<int>(
                name: "GoodsId",
                table: "UserRelations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRelations_GoodsId",
                table: "UserRelations",
                column: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelations_Goods_GoodsId",
                table: "UserRelations",
                column: "GoodsId",
                principalTable: "Goods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
