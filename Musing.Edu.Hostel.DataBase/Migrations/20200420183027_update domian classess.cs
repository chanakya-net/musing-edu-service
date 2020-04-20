using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class updatedomianclassess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOOccupantStaff",
                table: "Beds");

            migrationBuilder.AddColumn<bool>(
                name: "HasEmptyRooms",
                table: "Floors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupantStaff",
                table: "Beds",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasEmptyRooms",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "IsOccupantStaff",
                table: "Beds");

            migrationBuilder.AddColumn<bool>(
                name: "IsOOccupantStaff",
                table: "Beds",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
