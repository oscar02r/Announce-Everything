using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnounceEverything.Migrations
{
    public partial class AddAnnouncesComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Announces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditionId",
                table: "Announces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Announces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Announces_CategoryId",
                table: "Announces",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Announces_ConditionId",
                table: "Announces",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Announces_ProvinceId",
                table: "Announces",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announces_Categories_CategoryId",
                table: "Announces",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Announces_Conditions_ConditionId",
                table: "Announces",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Announces_Provinces_ProvinceId",
                table: "Announces",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announces_Categories_CategoryId",
                table: "Announces");

            migrationBuilder.DropForeignKey(
                name: "FK_Announces_Conditions_ConditionId",
                table: "Announces");

            migrationBuilder.DropForeignKey(
                name: "FK_Announces_Provinces_ProvinceId",
                table: "Announces");

            migrationBuilder.DropIndex(
                name: "IX_Announces_CategoryId",
                table: "Announces");

            migrationBuilder.DropIndex(
                name: "IX_Announces_ConditionId",
                table: "Announces");

            migrationBuilder.DropIndex(
                name: "IX_Announces_ProvinceId",
                table: "Announces");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Announces");

            migrationBuilder.DropColumn(
                name: "ConditionId",
                table: "Announces");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Announces");
        }
    }
}
