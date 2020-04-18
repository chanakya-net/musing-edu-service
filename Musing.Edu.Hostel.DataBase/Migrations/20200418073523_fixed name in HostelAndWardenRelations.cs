using Microsoft.EntityFrameworkCore.Migrations;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    public partial class fixednameinHostelAndWardenRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Hostels_MHostelId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAndWardenRelations_Hostels_MHostelId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropIndex(
                name: "IX_HostelAndWardenRelations_MHostelId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_MHostelId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "HostelId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropColumn(
                name: "MHostelId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropColumn(
                name: "MHostelId",
                table: "Buildings");

            migrationBuilder.AddColumn<int>(
                name: "HostelSetupId",
                table: "HostelAndWardenRelations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HostelSetupId",
                table: "Buildings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HostelAndWardenRelations_HostelSetupId",
                table: "HostelAndWardenRelations",
                column: "HostelSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_HostelSetupId",
                table: "Buildings",
                column: "HostelSetupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Hostels_HostelSetupId",
                table: "Buildings",
                column: "HostelSetupId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAndWardenRelations_Hostels_HostelSetupId",
                table: "HostelAndWardenRelations",
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

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAndWardenRelations_Hostels_HostelSetupId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropIndex(
                name: "IX_HostelAndWardenRelations_HostelSetupId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_HostelSetupId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "HostelSetupId",
                table: "HostelAndWardenRelations");

            migrationBuilder.DropColumn(
                name: "HostelSetupId",
                table: "Buildings");

            migrationBuilder.AddColumn<int>(
                name: "HostelId",
                table: "HostelAndWardenRelations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MHostelId",
                table: "HostelAndWardenRelations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MHostelId",
                table: "Buildings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HostelAndWardenRelations_MHostelId",
                table: "HostelAndWardenRelations",
                column: "MHostelId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_MHostelId",
                table: "Buildings",
                column: "MHostelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Hostels_MHostelId",
                table: "Buildings",
                column: "MHostelId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAndWardenRelations_Hostels_MHostelId",
                table: "HostelAndWardenRelations",
                column: "MHostelId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
