using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class changedcolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContectNumber",
                table: "User_Login_Information");

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "User_Login_Information",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "User_Login_Information");

            migrationBuilder.AddColumn<string>(
                name: "ContectNumber",
                table: "User_Login_Information",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
