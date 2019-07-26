using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class InsertDataIntoTables : Migration
    {

        string[] provinces = { "Azua", "Bahoruco", "Barahona", "Dajabón", "Distrito Nacional",
                "Duarte", "Elías Piña", "El Seibo", "Espaillat", "Hato Mayor", "Hermanas Mirabal",
                "Independencia","La Altagracia", "La Romana", "La Vega", "María Trinidad Sánchez",
                "Monseñor Nouel","Monte Cristi", "Monte Plata", "Pedernales", "Peravia", "Puerto Plata",
                 "Samaná", "Sánchez Ramírez", "San Cristóbal", "San José de Ocoa", "San Juan",
                "San Pedro de Macorís", "Santiago", "Santiago Rodríguez", "Santo Domingo","Valverde"};
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Sql("Insert into Type(Id, Name) Values(1, ‘Personal Superation’)"); Asi se hacia en framawork

            byte count = 1;

            foreach (var province in provinces)
            {

                migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[] { count, province }
                );
                count += 1;
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i < provinces.Length; i++)
            {
                migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: i
                );
            }
        }
    }
}
