using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class addedinstitute2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitureRecord",
                table: "InstitureRecord");

            migrationBuilder.RenameTable(
                name: "InstitureRecord",
                newName: "InstituteRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstituteRecord",
                table: "InstituteRecord",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstituteRecord",
                table: "InstituteRecord");

            migrationBuilder.RenameTable(
                name: "InstituteRecord",
                newName: "InstitureRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitureRecord",
                table: "InstitureRecord",
                column: "Id");
        }
    }
}
