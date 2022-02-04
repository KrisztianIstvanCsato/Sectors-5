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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorsDb", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "UsersDb",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Agreed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDb", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "UserSectorsDb",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSectorsDb", x => new { x.SectorId, x.UserName });
                    table.ForeignKey(
                        name: "FK_UserSectorsDb_SectorsDb_SectorId",
                        column: x => x.SectorId,
                        principalTable: "SectorsDb",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSectorsDb_UsersDb_UserName",
                        column: x => x.UserName,
                        principalTable: "UsersDb",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "SectorId", "Name" },
                values: new object[,]
                {
                    { 1, "Manufacturing" },
                    { 2, "Service" },
                    { 3, "Other" },
                    { 5, "Printing" },
                    { 6, "Food and Beverage" },
                    { 7, "Textile and Clothing" },
                    { 8, "Wood" },
                    { 9, "Plastic and Rubber" },
                    { 11, "Metalworking" },
                    { 12, "Machinery" },
                    { 13, "Furniture" },
                    { 18, "Electronics and Optics" },
                    { 19, "Construction materials" },
                    { 21, "Transport and Logistics" },
                    { 22, "Tourism" },
                    { 25, "Business services" },
                    { 28, "Information Technology and Telecommunications" },
                    { 29, "Energy technology" },
                    { 33, "Environment" },
                    { 35, "Engineering" },
                    { 37, "Creative industries" },
                    { 39, "Milk & dairy products" },
                    { 40, "Meat & meat products" },
                    { 42, "Fish & fish products" },
                    { 43, "Beverages" },
                    { 44, "Clothing" },
                    { 45, "Textile" },
                    { 47, "Wooden houses" },
                    { 51, "Wooden building materials" },
                    { 53, "Plastics welding and processing" },
                    { 54, "Packaging" },
                    { 55, "Blowing" },
                    { 57, "Moulding" },
                    { 62, "Forgings, Fasteners" },
                    { 66, "MIG, TIG, Aluminum welding" },
                    { 67, "Construction of metal structures" },
                    { 69, "Gas, Plasma, Laser cutting" },
                    { 75, "CNC-machining" },
                    { 91, "Machinery equipment/tools" },
                    { 93, "Metal structures" },
                    { 94, "Machinery components" },
                    { 97, "Maritime" }
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "SectorId", "Name" },
                values: new object[,]
                {
                    { 98, "Kitchen" },
                    { 99, "Project furniture" },
                    { 101, "Living room" },
                    { 111, "Air" },
                    { 112, "Road" },
                    { 113, "Water" },
                    { 114, "Rail" },
                    { 121, "Software, Hardware" },
                    { 122, "Telecommunications" },
                    { 141, "Translation services" },
                    { 145, "Labelling and packaging printing" },
                    { 148, "Advertising" },
                    { 150, "Book/Periodicals printing" },
                    { 224, "Manufacture of machinery" },
                    { 227, "Repair and maintenance service" },
                    { 230, "Ship repair and conversion" },
                    { 263, "Houses and buildings" },
                    { 267, "Metal products" },
                    { 269, "Boat/Yacht building" },
                    { 271, "Aluminium and steel workboats" },
                    { 337, "Other (Wood)" },
                    { 341, "Outdoor" },
                    { 342, "Bakery & confectionery products" },
                    { 378, "Sweets & snack food" },
                    { 385, "Bedroom" },
                    { 389, "Bathroom/sauna" },
                    { 390, "Children’s room" },
                    { 392, "Office" },
                    { 394, "Other (Furniture)" },
                    { 437, "Other" },
                    { 508, "Other" },
                    { 542, "Metal works" },
                    { 556, "Plastic goods" },
                    { 559, "Plastic processing technology" },
                    { 560, "Plastic profiles" },
                    { 576, "Programming, Consultancy" },
                    { 581, "Data processing, Web portals, E-marketing" }
                });

            migrationBuilder.InsertData(
                table: "UsersDb",
                columns: new[] { "Name", "Agreed", "Id" },
                values: new object[,]
                {
                    { "TestPerson1", true, 1 },
                    { "TestPerson2", true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSectorsDb_UserName",
                table: "UserSectorsDb",
                column: "UserName");
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
