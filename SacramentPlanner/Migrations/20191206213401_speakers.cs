using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class speakers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker",
                column: "MeetingId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingId",
                table: "Speaker",
                column: "MeetingId");
        }
    }
}
