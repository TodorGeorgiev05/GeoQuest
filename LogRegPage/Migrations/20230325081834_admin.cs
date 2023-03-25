using Microsoft.EntityFrameworkCore.Migrations;

namespace LogRegPage.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "ScoreGameOne", "ScoreGameTwo" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Grade", "Password", "ScoreId", "UserName", "UserType" },
                values: new object[] { 1, "1", "admin", 1, "admin", "Admin " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Grade", "Password", "ScoreId", "UserName", "UserType" },
                values: new object[] { 100, "1", "admin", 100, "admin", "Admin " });
        }
    }
}
