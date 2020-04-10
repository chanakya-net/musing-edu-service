using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class addedinstitute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstitureRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Pin = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    ContectNumbers = table.Column<string>(nullable: true),
                    MailId = table.Column<string>(nullable: true),
                    EstablishedOn = table.Column<DateTime>(nullable: false),
                    IsCoEd = table.Column<bool>(nullable: false),
                    genderType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitureRecord", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstitureRecord");
        }
    }
}
