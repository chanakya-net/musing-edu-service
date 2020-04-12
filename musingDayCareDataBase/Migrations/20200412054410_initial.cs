using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstituteRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Pin = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    ContactNumbers = table.Column<string>(nullable: true),
                    MailId = table.Column<string>(nullable: true),
                    EstablishedOn = table.Column<DateTime>(nullable: false),
                    IsCoEd = table.Column<bool>(nullable: false),
                    AllowedGender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituteRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetailInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRecrds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    UserDetailsId = table.Column<int>(nullable: true),
                    UserRefreshToken = table.Column<string>(nullable: true),
                    IsUserLocked = table.Column<bool>(nullable: false),
                    WrongLoginTries = table.Column<int>(nullable: false),
                    MaxLoginTryAllowed = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    ChangePasswordAtLogin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRecrds", x => x.Id);
                    table.UniqueConstraint("AK_UserRecrds_UserName", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_UserRecrds_UserDetailInformation_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "UserDetailInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_UserRecrds_UserId",
                        column: x => x.UserId,
                        principalTable: "UserRecrds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRecrds_UserDetailsId",
                table: "UserRecrds",
                column: "UserDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstituteRecord");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRecrds");

            migrationBuilder.DropTable(
                name: "UserDetailInformation");
        }
    }
}
