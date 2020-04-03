using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkDirectoryApi.Migrations
{
    public partial class IsOpen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "NationalParks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "NationalParks");
        }
    }
}
