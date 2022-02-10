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
                    Parent = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "SectorId", "Name", "Parent" },
                values: new object[,]
                {
                    { 1, "Manufacturing", 0 },
                    { 2, "Service", 0 },
                    { 3, "Other", 0 },
                    { 5, "Printing", 1 },
                    { 6, "Food and Beverage", 1 },
                    { 7, "Textile and Clothing", 1 },
                    { 8, "Wood", 1 },
                    { 9, "Plastic and Rubber", 1 },
                    { 11, "Metalworking", 1 },
                    { 12, "Machinery", 1 },
                    { 13, "Furniture", 1 },
                    { 18, "Electronics and Optics", 1 },
                    { 19, "Construction materials", 1 },
                    { 21, "Transport and Logistics", 2 },
                    { 22, "Tourism", 2 },
                    { 25, "Business services", 2 },
                    { 28, "Information Technology and Telecommunications", 2 },
                    { 29, "Energy technology", 3 },
                    { 33, "Environment", 3 },
                    { 35, "Engineering", 2 },
                    { 37, "Creative industries", 3 },
                    { 39, "Milk & dairy products", 6 },
                    { 40, "Meat & meat products", 6 },
                    { 42, "Fish & fish products", 6 },
                    { 43, "Beverages", 6 },
                    { 44, "Clothing", 7 },
                    { 45, "Textile", 7 },
                    { 47, "Wooden houses", 8 },
                    { 51, "Wooden building materials", 8 },
                    { 53, "Plastics welding and processing", 559 },
                    { 54, "Packaging", 9 },
                    { 55, "Blowing", 559 },
                    { 57, "Moulding", 559 },
                    { 62, "Forgings, Fasteners", 542 },
                    { 66, "MIG, TIG, Aluminum welding", 542 },
                    { 67, "Construction of metal structures", 11 },
                    { 69, "Gas, Plasma, Laser cutting", 542 },
                    { 75, "CNC-machining", 542 },
                    { 91, "Machinery equipment/tools", 12 },
                    { 93, "Metal structures", 12 },
                    { 94, "Machinery components", 12 },
                    { 97, "Maritime", 12 }
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "SectorId", "Name", "Parent" },
                values: new object[,]
                {
                    { 98, "Kitchen", 13 },
                    { 99, "Project furniture", 13 },
                    { 101, "Living room", 13 },
                    { 111, "Air", 21 },
                    { 112, "Road", 21 },
                    { 113, "Water", 21 },
                    { 114, "Rail", 21 },
                    { 121, "Software, Hardware", 28 },
                    { 122, "Telecommunications", 28 },
                    { 141, "Translation services", 2 },
                    { 145, "Labelling and packaging printing", 5 },
                    { 148, "Advertising", 5 },
                    { 150, "Book/Periodicals printing", 5 },
                    { 224, "Manufacture of machinery", 12 },
                    { 227, "Repair and maintenance service", 12 },
                    { 230, "Ship repair and conversion", 97 },
                    { 263, "Houses and buildings", 11 },
                    { 267, "Metal products", 11 },
                    { 269, "Boat/Yacht building", 97 },
                    { 271, "Aluminium and steel workboats", 97 },
                    { 337, "Other (Wood)", 8 },
                    { 341, "Outdoor", 13 },
                    { 342, "Bakery & confectionery products", 6 },
                    { 378, "Sweets & snack food", 6 },
                    { 385, "Bedroom", 13 },
                    { 389, "Bathroom/sauna", 13 },
                    { 390, "Children’s room", 13 },
                    { 392, "Office", 13 },
                    { 394, "Other (Furniture)", 13 },
                    { 437, "Other", 6 },
                    { 508, "Other", 12 },
                    { 542, "Metal works", 11 },
                    { 556, "Plastic goods", 9 },
                    { 559, "Plastic processing technology", 9 },
                    { 560, "Plastic profiles", 9 },
                    { 576, "Programming, Consultancy", 28 },
                    { 581, "Data processing, Web portals, E-marketing", 28 }
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
