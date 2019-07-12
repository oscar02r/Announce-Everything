using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsetDataToKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "UserKinds",
               columns: new[] { "Id", "Name" },
               values: new object[] { 1, "Paticular" }
               );

            migrationBuilder.InsertData(
                table: "UserKinds",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Tienda" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
              table: "UserKinds",
              keyColumn: "Id",
              keyValue: 1
              );

            migrationBuilder.DeleteData(
               table: "UserKinds",
               keyColumn: "Id",
               keyValue: 2
               );
        }
    }
}
