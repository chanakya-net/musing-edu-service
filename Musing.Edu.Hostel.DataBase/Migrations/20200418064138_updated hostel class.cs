using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class updatedhostelclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeneralInformation_Id",
                table: "Hostels");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_State",
                table: "Hostels",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_Pin",
                table: "Hostels",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_Name",
                table: "Hostels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_MailId",
                table: "Hostels",
                newName: "MailId");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_Country",
                table: "Hostels",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_ContactNumber",
                table: "Hostels",
                newName: "ContactNumber");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_City",
                table: "Hostels",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "GeneralInformation_Address",
                table: "Hostels",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Hostels",
                newName: "GeneralInformation_State");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Hostels",
                newName: "GeneralInformation_Pin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hostels",
                newName: "GeneralInformation_Name");

            migrationBuilder.RenameColumn(
                name: "MailId",
                table: "Hostels",
                newName: "GeneralInformation_MailId");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Hostels",
                newName: "GeneralInformation_Country");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Hostels",
                newName: "GeneralInformation_ContactNumber");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Hostels",
                newName: "GeneralInformation_City");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Hostels",
                newName: "GeneralInformation_Address");

            migrationBuilder.AddColumn<int>(
                name: "GeneralInformation_Id",
                table: "Hostels",
                type: "int",
                nullable: true);
        }
    }
}
