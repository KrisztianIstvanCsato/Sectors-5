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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorsDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agreed = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Sectors_SectorsDb_UserId",
                        column: x => x.UserId,
                        principalTable: "SectorsDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Sectors_UsersDb_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "Id", "Name", "SectorId" },
                values: new object[,]
                {
                    { 1, "Manufacturing", 1 },
                    { 2, "Construction materials", 19 },
                    { 3, "Electronics and Optics", 18 },
                    { 4, "Food and Beverage", 6 },
                    { 5, "Bakery & confectionery products", 342 },
                    { 6, "Beverages", 43 },
                    { 7, "Fish & fish products", 42 },
                    { 8, "Meat & meat products", 40 },
                    { 9, "Milk & dairy products", 39 },
                    { 10, "Other", 437 },
                    { 11, "Sweets & snack food", 378 },
                    { 12, "Furniture", 13 },
                    { 13, "Bathroom/sauna", 389 },
                    { 14, "Bedroom", 385 },
                    { 15, "Children’s room", 390 },
                    { 16, "Kitchen", 98 },
                    { 17, "Living room", 101 },
                    { 18, "Office", 392 },
                    { 19, "Other (Furniture)", 394 },
                    { 20, "Outdoor", 341 },
                    { 21, "Project furniture", 99 },
                    { 22, "Machinery", 12 },
                    { 23, "Machinery components", 94 },
                    { 24, "Machinery equipment/tools", 91 },
                    { 25, "Manufacture of machinery", 224 },
                    { 26, "Maritime", 97 },
                    { 27, "Aluminium and steel workboats", 271 },
                    { 28, "Boat/Yacht building", 269 },
                    { 29, "Ship repair and conversion", 230 },
                    { 30, "Metal structures", 93 },
                    { 31, "Other", 508 },
                    { 32, "Repair and maintenance service", 227 },
                    { 33, "Metalworking", 11 },
                    { 34, "Construction of metal structures", 67 },
                    { 35, "Houses and buildings", 263 },
                    { 36, "Metal products", 267 },
                    { 37, "Metal works", 542 },
                    { 38, "CNC-machining", 75 },
                    { 39, "Forgings, Fasteners", 62 },
                    { 40, "Gas, Plasma, Laser cutting", 69 },
                    { 41, "MIG, TIG, Aluminum welding", 66 },
                    { 42, "Plastic and Rubber", 9 }
                });

            migrationBuilder.InsertData(
                table: "SectorsDb",
                columns: new[] { "Id", "Name", "SectorId" },
                values: new object[,]
                {
                    { 43, "Packaging", 54 },
                    { 44, "Plastic goods", 556 },
                    { 45, "Plastic processing technology", 559 },
                    { 46, "Blowing", 55 },
                    { 47, "Moulding", 57 },
                    { 48, "Plastics welding and processing", 53 },
                    { 49, "Plastic profiles", 560 },
                    { 50, "Printing", 5 },
                    { 51, "Advertising", 148 },
                    { 52, "Book/Periodicals printing", 150 },
                    { 53, "Labelling and packaging printing", 145 },
                    { 54, "Textile and Clothing", 7 },
                    { 55, "Clothing", 44 },
                    { 56, "Textile", 45 },
                    { 57, "Wood", 8 },
                    { 58, "Other (Wood)", 337 },
                    { 59, "Wooden building materials", 51 },
                    { 60, "Wooden houses", 47 },
                    { 61, "Other", 3 },
                    { 62, "Creative industries", 37 },
                    { 63, "Energy technology", 29 },
                    { 64, "Environment", 33 },
                    { 65, "Service", 2 },
                    { 66, "Business services", 25 },
                    { 67, "Engineering", 35 },
                    { 68, "Information Technology and Telecommunications", 28 },
                    { 69, "Data processing, Web portals, E-marketing", 581 },
                    { 70, "Programming, Consultancy", 576 },
                    { 71, "Software, Hardware", 121 },
                    { 72, "Telecommunications", 122 },
                    { 73, "Tourism", 22 },
                    { 74, "Translation services", 141 },
                    { 75, "Transport and Logistics", 21 },
                    { 76, "Air", 111 },
                    { 77, "Rail", 114 },
                    { 78, "Road", 112 },
                    { 79, "Water", 113 }
                });

            migrationBuilder.InsertData(
                table: "UsersDb",
                columns: new[] { "Id", "Agreed", "Name", "SectorId", "UserId" },
                values: new object[] { 1, true, "TestPerson", 0, 0 });

            migrationBuilder.InsertData(
                table: "User_Sectors",
                columns: new[] { "Id", "SectorId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "User_Sectors",
                columns: new[] { "Id", "SectorId", "UserId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_User_Sectors_UserId",
                table: "User_Sectors",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Sectors");

            migrationBuilder.DropTable(
                name: "SectorsDb");

            migrationBuilder.DropTable(
                name: "UsersDb");
        }
    }
}
