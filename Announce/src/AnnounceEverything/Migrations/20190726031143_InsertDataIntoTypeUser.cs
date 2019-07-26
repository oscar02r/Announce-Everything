using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsertDataIntoTypeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "TypeUsers",
              columns: new[] { "Id", "Name" },
              values: new object[] { 1, "Paticular" }
              );

            migrationBuilder.InsertData(
                table: "TypeUsers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Tienda" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
             table: "TypeUsers",
             keyColumn: "Id",
             keyValue: 1
             );

            migrationBuilder.DeleteData(
               table: "TypeUsers",
               keyColumn: "Id",
               keyValue: 2
               );
        }
    }
}
