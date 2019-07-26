using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsertDataIntoCategory : Migration
    {
        string[] categories = { "Accesorios para Vehículos", "Arte y Antigüedades", "Cámaras Digitales y Foto",
                               "Carros, Motos y Otros","Celulares y Teléfonos","Computación","Consolas y Videojuegos",
                               "Deportes y Fitness","Electrónica Audio Video","Electrodomésticos","Inmuebles","Juegos",
                               "Libros","Ropa, Relojes y Lentes","Empleos"
        };
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Sql("Insert into Type(Id, Name) Values(1, ‘Personal Superation’)"); Asi se hacia en framawork

            byte count = 1;

            foreach (var category in categories)
            {

                migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { count, category }
                );
                count += 1;
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            for (int i = 1; i < categories.Length; i++)
            {
                migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: i
                );
            }
        }
    }
}
