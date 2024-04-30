using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labology.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddClientTodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Dist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<int>(type: "int", nullable: false),
                    LandMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    OfficerId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Officers_OfficerId",
                        column: x => x.OfficerId,
                        principalTable: "Officers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CName", "Dist", "ImageUrl", "LandMark", "Mobile", "OfficerId", "Pin", "Pos", "Total" },
                values: new object[,]
                {
                    { 1, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 1, 90, "Pankapal", 1399.0 },
                    { 2, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 2, 90, "Pankapal", 1399.0 },
                    { 3, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 1, 90, "Pankapal", 1399.0 },
                    { 4, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 2, 90, "Pankapal", 1399.0 },
                    { 5, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 1, 90, "Pankapal", 1399.0 },
                    { 6, "Fortune of Time", "SWD9999001", "", "Near bara gachha", 123456789, 2, 90, "Pankapal", 1399.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_OfficerId",
                table: "Clients",
                column: "OfficerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
