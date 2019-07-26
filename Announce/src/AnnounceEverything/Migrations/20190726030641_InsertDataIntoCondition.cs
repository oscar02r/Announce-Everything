using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsertDataIntoCondition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Conditions",
               columns: new[] { "Id", "Name" },
               values: new object[] { 1, "Nuevo" }
               );

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Usado" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
             table: "Conditions",
             keyColumn: "Id",
             keyValue: 1
             );

            migrationBuilder.DeleteData(
               table: "Conditions",
               keyColumn: "Id",
               keyValue: 2
               );
        }
    }
}
