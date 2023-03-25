using Microsoft.EntityFrameworkCore.Migrations;

namespace LogRegPage.Migrations
{
    public partial class dict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoreGameOne = table.Column<int>(nullable: false),
                    ScoreGameTwo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: true),
                    UserType = table.Column<string>(maxLength: 30, nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: true),
                    Grade = table.Column<string>(maxLength: 30, nullable: true),
                    ScoreId = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_Scores_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Scores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "Name" },
                values: new object[,]
                {
                    { 1, "AL", "Albania" },
                    { 28, "LU", "Luxembourg" },
                    { 29, "MK", "North Macedonia" },
                    { 30, "MT", "Malta" },
                    { 31, "MD", "Moldova" },
                    { 32, "MC", "Monaco" },
                    { 33, "ME", "Montenegro" },
                    { 34, "NL", "The Netherlands" },
                    { 35, "NO", "Norway" },
                    { 36, "PL", "Poland" },
                    { 37, "PT", "Portugal" },
                    { 27, "LT", "Lithuania" },
                    { 38, "RO", "Romania" },
                    { 40, "SM", "San Marino" },
                    { 41, "RS", "Serbia" },
                    { 42, "SK", "Slovakia" },
                    { 43, "SI", "Slovenia" },
                    { 44, "ES", "Spain" },
                    { 45, "SE", "Sweden" },
                    { 46, "CH", "Switzerland" },
                    { 47, "TR", "Türkiye" },
                    { 48, "UA", "Ukraine" },
                    { 49, "UK", "United Kingdom" },
                    { 39, "RU", "Russia" },
                    { 50, "VA", "Vatican City" },
                    { 26, "LI", "Liechtenstein" },
                    { 24, "XK", "Kosovo" },
                    { 2, "AD", "Andorra" },
                    { 3, "AT", "Austria" },
                    { 4, "AZ", "Azerbaijan" },
                    { 5, "AM", "Armenia" },
                    { 6, "BY", "Belarus" },
                    { 7, "BE", "Belgium" },
                    { 8, "BA", "Bosnia and Herzegovina" },
                    { 9, "BG", "Bulgaria" },
                    { 10, "HR", "Croatia" },
                    { 11, "CY", "Cyprus" },
                    { 25, "LV", "Latvia" },
                    { 12, "CZ", "Czech Republic" },
                    { 14, "EE", "Estonia" },
                    { 15, "FI", "Finland" },
                    { 16, "FR", "France" },
                    { 17, "DE", "Germany" },
                    { 18, "GE", "Georgia" },
                    { 19, "GR", "Greece" },
                    { 20, "HU", "Hungary" },
                    { 21, "IS", "Iceland" },
                    { 22, "IE", "Ireland" },
                    { 23, "IT", "Italy" },
                    { 13, "DK", "Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "ScoreGameOne", "ScoreGameTwo" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Grade", "Password", "ScoreId", "UserName", "UserType" },
                values: new object[] { 1, "1", "admin", 1, "admin", "Admin " });

            migrationBuilder.CreateIndex(
                name: "IX_users_ScoreId",
                table: "users",
                column: "ScoreId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
