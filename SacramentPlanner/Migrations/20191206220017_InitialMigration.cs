using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Presiding = table.Column<string>(nullable: true),
                    OpeningHymn = table.Column<string>(nullable: true),
                    OpeningHymnNumber = table.Column<int>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    SacramentHymnNumber = table.Column<int>(nullable: false),
                    IntermediateHymn = table.Column<string>(nullable: true),
                    IntermediateHymnNumber = table.Column<int>(nullable: false),
                    ClosingHymn = table.Column<string>(nullable: true),
                    ClosingHymnNumber = table.Column<int>(nullable: false),
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingId);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingId = table.Column<int>(nullable: false),
                    SpeakerName = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meeting",
                        principalColumn: "MeetingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker",
                column: "MeetingId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
