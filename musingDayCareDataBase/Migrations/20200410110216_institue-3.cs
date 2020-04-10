using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class institue3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "genderType",
                table: "InstituteRecord");

            migrationBuilder.AddColumn<int>(
                name: "AllowedGender",
                table: "InstituteRecord",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowedGender",
                table: "InstituteRecord");

            migrationBuilder.AddColumn<int>(
                name: "genderType",
                table: "InstituteRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
