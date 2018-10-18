using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanetObjs",
                columns: table => new
                {
                    PlanetObjId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DetailImage = table.Column<string>(nullable: true),
                    SellType = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetObjs", x => x.PlanetObjId);
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PlanetObjId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                    table.ForeignKey(
                        name: "FK_Realtors_PlanetObjs_PlanetObjId",
                        column: x => x.PlanetObjId,
                        principalTable: "PlanetObjs",
                        principalColumn: "PlanetObjId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PlanetObjs",
                columns: new[] { "PlanetObjId", "Color", "DetailImage", "Image", "Name", "Price", "SellType", "Shape", "Size" },
                values: new object[,]
                {
                    { 1, "Yellow", "sednadetails.jpg", "sedna.jpg", "Sedna", "1.5", "Featured", "Round", "Average" },
                    { 2, "Grey", "mercurydetails.jpg", "mercury.jpg", "Mercury", "4.5", "New", "Sphere", "Large" },
                    { 3, "Yellow", "venusdetails.jpg", "venus.jpg", "Venus", "1.5", "Offer", "Potato", "Small" },
                    { 4, "Red", "lavadetails.jpg", "lava.jpg", "Lava", "4.5", "On Sale", "Sphere", "Large" },
                    { 5, "Yellow", "jupiterdetails.jpg", "jupiter.jpg", "Jupiter", "2.5", "Featured", "Round", "Average" },
                    { 6, "Blue", "uranusdetails.jpg", "uranus.jpg", "Uranus", "5.5", "Offer", "Potato", "Large" },
                    { 7, "Yellow", "saturndetails.jpg", "saturn.jpg", "Saturn", "2.5", "Featured", "Round", "Large" },
                    { 8, "Blue", "x-3details.jpg", "x-3.jpg", "X-3", "2.5", "Featured", "Sphere", "Average" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_PlanetObjId",
                table: "Realtors",
                column: "PlanetObjId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropTable(
                name: "PlanetObjs");
        }
    }
}
