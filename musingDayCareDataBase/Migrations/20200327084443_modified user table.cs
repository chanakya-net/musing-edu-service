using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class modifiedusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ChangePasswordAtLogin",
                table: "User_Login_Information",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContectNumber",
                table: "User_Login_Information",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsUserLocked",
                table: "User_Login_Information",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxLoginTryAllowed",
                table: "User_Login_Information",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserRefreshToken",
                table: "User_Login_Information",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WrongLoginTries",
                table: "User_Login_Information",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangePasswordAtLogin",
                table: "User_Login_Information");

            migrationBuilder.DropColumn(
                name: "ContectNumber",
                table: "User_Login_Information");

            migrationBuilder.DropColumn(
                name: "IsUserLocked",
                table: "User_Login_Information");

            migrationBuilder.DropColumn(
                name: "MaxLoginTryAllowed",
                table: "User_Login_Information");

            migrationBuilder.DropColumn(
                name: "UserRefreshToken",
                table: "User_Login_Information");

            migrationBuilder.DropColumn(
                name: "WrongLoginTries",
                table: "User_Login_Information");
        }
    }
}
