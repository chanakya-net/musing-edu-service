using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class addedforeginkeiinbuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Hostels_HostelSetupId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "HostelSetupId",
                table: "Buildings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Hostels_HostelSetupId",
                table: "Buildings",
                column: "HostelSetupId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Hostels_HostelSetupId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "HostelSetupId",
                table: "Buildings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Hostels_HostelSetupId",
                table: "Buildings",
                column: "HostelSetupId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
