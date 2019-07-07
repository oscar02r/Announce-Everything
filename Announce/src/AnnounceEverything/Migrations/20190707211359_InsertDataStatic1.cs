using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsertDataStatic1 : Migration
    {
      

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Sql("Insert into Type(Id, Name) Values(1, ‘Personal Superation’)"); Asi se hacia en framawork

            //migrationBuilder.InsertData(
            //table: "Types",
            //columns: new[] { "Id", "Name" },
            //values: new object[] { 1, "Personal Superation" });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //table: "Types",
            //keyColumn: "Id",
            //keyValue: 1);
        }
    }
}
