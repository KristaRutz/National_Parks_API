using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkDirectoryApi.Migrations
{
    public partial class InitialWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AlphaCode = table.Column<string>(nullable: true),
                    StateCode = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    IsOpen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "AlphaCode", "IsOpen", "Name", "Region", "StateCode", "Url" },
                values: new object[,]
                {
                    { 1, "ACAD", false, "Acadia National Park", "Northeast", "ME", "https://www.nps.gov/acad/index.htm" },
                    { 16, "DEVA", true, "Death Valley National Park", "Pacific-West", "CA", "https://www.nps.gov/deva/index.htm" },
                    { 15, "CUVA", false, "Cuyahoga Valley National Park", "Midwest", "OH", "https://www.nps.gov/cuva/index.htm" },
                    { 14, "CRLA", true, "Crater Lake National Park", "Pacific-West", "OR", "https://www.nps.gov/crla/index.htm" },
                    { 13, "COSW", false, "Congaree National Park", "Southeast", "SC", "https://www.nps.gov/cosw/index.htm" },
                    { 12, "CHIS", true, "Channel Islands National Park", "Pacific-West", "CA", "https://www.nps.gov/chis/index.htm" },
                    { 11, "CAVE", false, "Carlsbad Caverns National Park", "Intermountain", "NM", "https://www.nps.gov/cave/index.htm" },
                    { 10, "CARE", true, "Capitol Reef National Park", "Intermountain", "UT", "https://www.nps.gov/care/index.htm" },
                    { 9, "CANY", false, "Canyonlands National Park", "Intermountain", "UT", "https://www.nps.gov/cany/index.htm" },
                    { 8, "BRCA", true, "Bryce Canyon National Park", "Intermountain", "UT", "https://www.nps.gov/brca/index.htm" },
                    { 7, "BLCA", false, "Black Canyon of the Gunnison National Park", "Intermountain", "CO", "https://www.nps.gov/blca/index.htm" },
                    { 6, "BISC", true, "Biscayne National Park", "Southeast", "FL", "https://www.nps.gov/bisc/index.htm" },
                    { 5, "BIBE", false, "Big Bend National Park", "Intermountain", "TX", "https://www.nps.gov/bibe/index.htm" },
                    { 4, "BADL", false, "Badlands National Park", "Midwest", "SD", "https://www.nps.gov/badl/index.htm" },
                    { 3, "ARCH", false, "Arches National Park", "Intermountain", "UT", "https://www.nps.gov/arch/index.htm" },
                    { 2, "NPSA", true, "National Park of American Samoa", "Pacific-West", "AS", "https://www.nps.gov/npsa/index.htm" },
                    { 17, "DENA", false, "Denali National Park", "Alaska", "AK", "https://www.nps.gov/dena/index.htm" },
                    { 18, "DRTO", true, "Dry Tortugas National Park", "Southeast", "FL", "https://www.nps.gov/drto/index.htm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");
        }
    }
}
