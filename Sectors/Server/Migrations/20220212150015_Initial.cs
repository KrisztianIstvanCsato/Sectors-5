using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sectors.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SectorsDb",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorsDb", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "UsersDb",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agreed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDb", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserSectorsDb",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSectorsDb", x => new { x.SectorId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserSectorsDb_SectorsDb_SectorId",
                        column: x => x.SectorId,
                        principalTable: "SectorsDb",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSectorsDb_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "SectorId", "Level", "Name", "Parent" },
                values: new object[,]
                {
                    { 1, 0, "Manufacturing", 0 },
                    { 2, 0, "Service", 0 },
                    { 3, 0, "Other", 0 },
                    { 5, 1, "Printing", 1 },
                    { 6, 1, "Food and Beverage", 1 },
                    { 7, 1, "Textile and Clothing", 1 },
                    { 8, 1, "Wood", 1 },
                    { 9, 1, "Plastic and Rubber", 1 },
                    { 11, 1, "Metalworking", 1 },
                    { 12, 1, "Machinery", 1 },
                    { 13, 1, "Furniture", 1 },
                    { 18, 1, "Electronics and Optics", 1 },
                    { 19, 1, "Construction materials", 1 },
                    { 21, 1, "Transport and Logistics", 2 },
                    { 22, 1, "Tourism", 2 },
                    { 25, 1, "Business services", 2 },
                    { 28, 1, "Information Technology and Telecommunications", 2 },
                    { 29, 1, "Energy technology", 3 },
                    { 33, 1, "Environment", 3 },
                    { 35, 1, "Engineering", 2 },
                    { 37, 1, "Creative industries", 3 },
                    { 39, 2, "Milk & dairy products", 6 },
                    { 40, 2, "Meat & meat products", 6 },
                    { 42, 2, "Fish & fish products", 6 },
                    { 43, 2, "Beverages", 6 },
                    { 44, 2, "Clothing", 7 },
                    { 45, 2, "Textile", 7 },
                    { 47, 2, "Wooden houses", 8 },
                    { 51, 2, "Wooden building materials", 8 },
                    { 53, 3, "Plastics welding and processing", 559 },
                    { 54, 2, "Packaging", 9 },
                    { 55, 3, "Blowing", 559 },
                    { 57, 3, "Moulding", 559 },
                    { 62, 3, "Forgings, Fasteners", 542 },
                    { 66, 3, "MIG, TIG, Aluminum welding", 542 },
                    { 67, 2, "Construction of metal structures", 11 },
                    { 69, 3, "Gas, Plasma, Laser cutting", 542 },
                    { 75, 3, "CNC-machining", 542 },
                    { 91, 2, "Machinery equipment/tools", 12 },
                    { 93, 2, "Metal structures", 12 },
                    { 94, 2, "Machinery components", 12 },
                    { 97, 2, "Maritime", 12 }
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "SectorId", "Level", "Name", "Parent" },
                values: new object[,]
                {
                    { 98, 2, "Kitchen", 13 },
                    { 99, 2, "Project furniture", 13 },
                    { 101, 2, "Living room", 13 },
                    { 111, 2, "Air", 21 },
                    { 112, 2, "Road", 21 },
                    { 113, 2, "Water", 21 },
                    { 114, 2, "Rail", 21 },
                    { 121, 2, "Software, Hardware", 28 },
                    { 122, 2, "Telecommunications", 28 },
                    { 141, 1, "Translation services", 2 },
                    { 145, 2, "Labelling and packaging printing", 5 },
                    { 148, 2, "Advertising", 5 },
                    { 150, 2, "Book/Periodicals printing", 5 },
                    { 224, 2, "Manufacture of machinery", 12 },
                    { 227, 2, "Repair and maintenance service", 12 },
                    { 230, 3, "Ship repair and conversion", 97 },
                    { 263, 2, "Houses and buildings", 11 },
                    { 267, 2, "Metal products", 11 },
                    { 269, 3, "Boat/Yacht building", 97 },
                    { 271, 3, "Aluminium and steel workboats", 97 },
                    { 337, 2, "Other (Wood)", 8 },
                    { 341, 2, "Outdoor", 13 },
                    { 342, 2, "Bakery & confectionery products", 6 },
                    { 378, 2, "Sweets & snack food", 6 },
                    { 385, 2, "Bedroom", 13 },
                    { 389, 2, "Bathroom/sauna", 13 },
                    { 390, 2, "Children’s room", 13 },
                    { 392, 2, "Office", 13 },
                    { 394, 2, "Other (Furniture)", 13 },
                    { 437, 2, "Other", 6 },
                    { 508, 2, "Other", 12 },
                    { 542, 2, "Metal works", 11 },
                    { 556, 2, "Plastic goods", 9 },
                    { 559, 2, "Plastic processing technology", 9 },
                    { 560, 2, "Plastic profiles", 9 },
                    { 576, 2, "Programming, Consultancy", 28 },
                    { 581, 2, "Data processing, Web portals, E-marketing", 28 }
                });

            migrationBuilder.InsertData(
                table: "UsersDb",
                columns: new[] { "UserId", "Agreed", "Name" },
                values: new object[,]
                {
                    { 1, true, "TestPerson1" },
                    { 2, true, "TestPerson2" }
                });

            migrationBuilder.InsertData(
                table: "UserSectorsDb",
                columns: new[] { "SectorId", "UserId" },
                values: new object[,]
                {
                    { 25, 1 },
                    { 37, 2 },
                    { 267, 2 },
                    { 576, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSectorsDb_UserId",
                table: "UserSectorsDb",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSectorsDb");

            migrationBuilder.DropTable(
                name: "SectorsDb");

            migrationBuilder.DropTable(
                name: "UsersDb");
        }
    }
}
