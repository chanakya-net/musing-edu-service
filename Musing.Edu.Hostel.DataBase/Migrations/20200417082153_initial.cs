using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hostels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralInformation_Id = table.Column<int>(nullable: true),
                    GeneralInformation_Name = table.Column<string>(nullable: true),
                    GeneralInformation_Address = table.Column<string>(nullable: true),
                    GeneralInformation_City = table.Column<string>(nullable: true),
                    GeneralInformation_Pin = table.Column<string>(nullable: true),
                    GeneralInformation_State = table.Column<string>(nullable: true),
                    GeneralInformation_Country = table.Column<string>(nullable: true),
                    GeneralInformation_ContactNumber = table.Column<string>(nullable: true),
                    GeneralInformation_MailId = table.Column<string>(nullable: true),
                    AllowedGender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wardens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Pin = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    MailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wardens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(nullable: true),
                    MHostelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Hostels_MHostelId",
                        column: x => x.MHostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HostelAndWardenRelations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostelId = table.Column<int>(nullable: false),
                    WardenId = table.Column<int>(nullable: false),
                    WardenAssignedStartDate = table.Column<DateTime>(nullable: false),
                    WardenAssignedEndDate = table.Column<DateTime>(nullable: false),
                    MHostelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostelAndWardenRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostelAndWardenRelations_Hostels_MHostelId",
                        column: x => x.MHostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostelAndWardenRelations_Wardens_WardenId",
                        column: x => x.WardenId,
                        principalTable: "Wardens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(nullable: false),
                    FloorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorId = table.Column<int>(nullable: false),
                    RoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(nullable: false),
                    BedName = table.Column<string>(nullable: true),
                    Charge = table.Column<decimal>(nullable: false),
                    ChargeOccurencePeriodType = table.Column<int>(nullable: false),
                    ChargeOccurencePeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beds_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beds_RoomId",
                table: "Beds",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_MHostelId",
                table: "Buildings",
                column: "MHostelId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAndWardenRelations_MHostelId",
                table: "HostelAndWardenRelations",
                column: "MHostelId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAndWardenRelations_WardenId",
                table: "HostelAndWardenRelations",
                column: "WardenId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FloorId",
                table: "Rooms",
                column: "FloorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "HostelAndWardenRelations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Wardens");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Hostels");
        }
    }
}
