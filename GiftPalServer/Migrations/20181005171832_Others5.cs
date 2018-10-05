using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class Others5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SentGoods_Gifts_GiftsId",
                table: "SentGoods");

            migrationBuilder.DropIndex(
                name: "IX_SentGoods_GiftsId",
                table: "SentGoods");

            migrationBuilder.DropColumn(
                name: "GiftsId",
                table: "SentGoods");

            migrationBuilder.CreateIndex(
                name: "IX_SentGoods_GiftId",
                table: "SentGoods",
                column: "GiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_SentGoods_Gifts_GiftId",
                table: "SentGoods",
                column: "GiftId",
                principalTable: "Gifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SentGoods_Gifts_GiftId",
                table: "SentGoods");

            migrationBuilder.DropIndex(
                name: "IX_SentGoods_GiftId",
                table: "SentGoods");

            migrationBuilder.AddColumn<int>(
                name: "GiftsId",
                table: "SentGoods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SentGoods_GiftsId",
                table: "SentGoods",
                column: "GiftsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SentGoods_Gifts_GiftsId",
                table: "SentGoods",
                column: "GiftsId",
                principalTable: "Gifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
