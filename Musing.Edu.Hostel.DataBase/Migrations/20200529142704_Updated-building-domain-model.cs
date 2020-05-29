using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class Updatedbuildingdomainmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailId",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pin",
                table: "Buildings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Buildings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "MailId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Buildings");
        }
    }
}
