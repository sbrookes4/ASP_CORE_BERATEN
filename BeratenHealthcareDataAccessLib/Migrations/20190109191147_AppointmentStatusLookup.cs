using Microsoft.EntityFrameworkCore.Migrations;

namespace BeratenHealthcareDataAccessLib.Migrations
{
    public partial class AppointmentStatusLookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentStatusLookupId",
                table: "ProgressNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppointmentStatusLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatusLookup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_AppointmentStatusLookupId",
                table: "ProgressNotes",
                column: "AppointmentStatusLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressNotes_AppointmentStatusLookup_AppointmentStatusLookupId",
                table: "ProgressNotes",
                column: "AppointmentStatusLookupId",
                principalTable: "AppointmentStatusLookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgressNotes_AppointmentStatusLookup_AppointmentStatusLookupId",
                table: "ProgressNotes");

            migrationBuilder.DropTable(
                name: "AppointmentStatusLookup");

            migrationBuilder.DropIndex(
                name: "IX_ProgressNotes_AppointmentStatusLookupId",
                table: "ProgressNotes");

            migrationBuilder.DropColumn(
                name: "AppointmentStatusLookupId",
                table: "ProgressNotes");
        }
    }
}
