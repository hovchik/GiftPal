using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class Others7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_ReceivedGoods_ReceivedGoodsId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_SentGoods_SentGoodsId",
                table: "Goods");

            migrationBuilder.AlterColumn<int>(
                name: "SentGoodsId",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReceivedGoodsId",
                table: "Goods",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_ReceivedGoods_ReceivedGoodsId",
                table: "Goods",
                column: "ReceivedGoodsId",
                principalTable: "ReceivedGoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_SentGoods_SentGoodsId",
                table: "Goods",
                column: "SentGoodsId",
                principalTable: "SentGoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_ReceivedGoods_ReceivedGoodsId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_SentGoods_SentGoodsId",
                table: "Goods");

            migrationBuilder.AlterColumn<int>(
                name: "SentGoodsId",
                table: "Goods",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceivedGoodsId",
                table: "Goods",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_ReceivedGoods_ReceivedGoodsId",
                table: "Goods",
                column: "ReceivedGoodsId",
                principalTable: "ReceivedGoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_SentGoods_SentGoodsId",
                table: "Goods",
                column: "SentGoodsId",
                principalTable: "SentGoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
