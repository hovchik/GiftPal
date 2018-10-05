using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class Others : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoodsId",
                table: "UserRelations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GiftsId",
                table: "SentGoods",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GiftsId",
                table: "ReceivedGoods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRelations_GoodsId",
                table: "UserRelations",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_UserId",
                table: "ShippingAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SentGoods_GiftsId",
                table: "SentGoods",
                column: "GiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedGoods_GiftsId",
                table: "ReceivedGoods",
                column: "GiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ReceivedGoodsId",
                table: "Goods",
                column: "ReceivedGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_SentGoodsId",
                table: "Goods",
                column: "SentGoodsId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ReceivedGoods_Gifts_GiftsId",
                table: "ReceivedGoods",
                column: "GiftsId",
                principalTable: "Gifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentGoods_Gifts_GiftsId",
                table: "SentGoods",
                column: "GiftsId",
                principalTable: "Gifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_Users_UserId",
                table: "ShippingAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelations_Goods_GoodsId",
                table: "UserRelations",
                column: "GoodsId",
                principalTable: "Goods",
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

            migrationBuilder.DropForeignKey(
                name: "FK_ReceivedGoods_Gifts_GiftsId",
                table: "ReceivedGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_SentGoods_Gifts_GiftsId",
                table: "SentGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_Users_UserId",
                table: "ShippingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRelations_Goods_GoodsId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_UserRelations_GoodsId",
                table: "UserRelations");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_UserId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_SentGoods_GiftsId",
                table: "SentGoods");

            migrationBuilder.DropIndex(
                name: "IX_ReceivedGoods_GiftsId",
                table: "ReceivedGoods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_ReceivedGoodsId",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_SentGoodsId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "GoodsId",
                table: "UserRelations");

            migrationBuilder.DropColumn(
                name: "GiftsId",
                table: "SentGoods");

            migrationBuilder.DropColumn(
                name: "GiftsId",
                table: "ReceivedGoods");
        }
    }
}
