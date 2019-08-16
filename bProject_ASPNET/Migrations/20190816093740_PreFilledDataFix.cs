using Microsoft.EntityFrameworkCore.Migrations;

namespace bProject_ASPNET.Migrations
{
    public partial class PreFilledDataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Name", "UserHobby" },
                values: new object[] { 3, "firstuser@gmail.com", "First User", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
