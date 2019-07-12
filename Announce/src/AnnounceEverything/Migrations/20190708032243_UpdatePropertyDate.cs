using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class UpdatePropertyDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Announces",
                newName: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Announces",
                newName: "Date");
        }
    }
}
