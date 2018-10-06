using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftPalServer.Migrations
{
    public partial class xxy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSending",
                table: "ToSends",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSending",
                table: "ToSends");
        }
    }
}
