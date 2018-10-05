using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "UserRelations");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "UserRelations",
                nullable: false,
                defaultValue: 0);
        }
    }
}
