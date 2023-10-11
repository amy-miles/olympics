using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS174_AmyMiles.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SettingID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Divisions",
                        principalColumn: "DivisionID");
                    table.ForeignKey(
                        name: "FK_Countries_Settings_SettingID",
                        column: x => x.SettingID,
                        principalTable: "Settings",
                        principalColumn: "SettingID");
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID");
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionID", "Name" },
                values: new object[,]
                {
                    { "para", "Paralympics" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "SettingID", "Name" },
                values: new object[,]
                {
                    { "in", "Indoor" },
                    { "out", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Name" },
                values: new object[,]
                {
                    { "archery", "Archery" },
                    { "bdance", "Breakdancing" },
                    { "bob", "Bobsleigh" },
                    { "canoe", "Canoe Sprint" },
                    { "curl", "Curling" },
                    { "cycling", "Road Cycling" },
                    { "diving", "Diving" },
                    { "skateb", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "DivisionID", "LogoImage", "Name", "SettingID", "SportID" },
                values: new object[,]
                {
                    { "austria", "para", "austria.jpg", "Austria", "out", "canoe" },
                    { "brazil", "summer", "brazil.jpg", "Brazil", "out", "cycling" },
                    { "canada", "winter", "canada.jpg", "Canada", "in", "curl" },
                    { "china", "summer", "china.jpg", "China", "in", "diving" },
                    { "cyprus", "youth", "cyprus.jpg", "Cyprus", "in", "bdance" },
                    { "finland", "youth", "finland.jpg", "Finland", "out", "skateb" },
                    { "france", "youth", "france.jpg", "France", "in", "bdance" },
                    { "germany", "summer", "germany.jpg", "Germany", "in", "diving" },
                    { "great_britain", "winter", "great_britain.jpg", "Great Britain", "in", "curl" },
                    { "italy", "winter", "italy.jpg", "Italy", "out", "bob" },
                    { "jamaica", "winter", "jamaica.jpg", "Jamaica", "out", "bob" },
                    { "japan", "winter", "japan.jpg", "Japan", "out", "bob" },
                    { "mexico", "summer", "mexico.jpg", "Mexico", "in", "diving" },
                    { "netherlands", "summer", "netherlands.jpg", "Netherlands", "out", "cycling" },
                    { "pakistan", "para", "pakistan.jpg", "Pakistan", "out", "canoe" },
                    { "portugal", "youth", "portugal.jpg", "Portugal", "out", "skateb" },
                    { "russia", "youth", "russia.jpg", "Russia", "in", "bdance" },
                    { "slovakia", "youth", "slovakia.jpg", "Slovakia", "out", "skateb" },
                    { "sweden", "winter", "sweden.jpg", "Sweden", "in", "curl" },
                    { "thailand", "para", "thailand.jpg", "Thailand", "in", "archery" },
                    { "ukraine", "para", "ukraine.jpg", "Ukraine", "in", "archery" },
                    { "uruguay", "para", "uruguay.jpg", "Uruguay", "in", "archery" },
                    { "usa", "summer", "united_states.jpg", "USA", "out", "cycling" },
                    { "zimbabwe", "para", "zimbabwe.jpg", "Zimbabwe", "out", "canoe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DivisionID",
                table: "Countries",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SettingID",
                table: "Countries",
                column: "SettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
