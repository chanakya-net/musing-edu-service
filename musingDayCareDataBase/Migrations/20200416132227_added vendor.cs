using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace musingDayCareDataBase.Migrations
{
    public partial class addedvendor : Migration
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
                    AllowedGender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituteRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecord", x => x.Id);
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
                name: "VendorRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Pin = table.Column<string>(nullable: true),
                    ContactNumbers = table.Column<string>(nullable: true),
                    MailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorRecord", x => x.Id);
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
                name: "VendorAndServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorID = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorAndServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorAndServices_ServiceRecord_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ServiceRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendorAndServices_VendorRecord_VendorID",
                        column: x => x.VendorID,
                        principalTable: "VendorRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_VendorAndServices_ServiceId",
                table: "VendorAndServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorAndServices_VendorID",
                table: "VendorAndServices",
                column: "VendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstituteRecord");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "VendorAndServices");

            migrationBuilder.DropTable(
                name: "UserRecrds");

            migrationBuilder.DropTable(
                name: "ServiceRecord");

            migrationBuilder.DropTable(
                name: "VendorRecord");

            migrationBuilder.DropTable(
                name: "UserDetailInformation");
        }
    }
}
