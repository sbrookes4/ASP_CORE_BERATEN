using Microsoft.EntityFrameworkCore.Migrations;

namespace BeratenHealthcareDataAccessLib.Migrations
{
    public partial class RemoveFacilityId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Facilities_FacilityId",
                table: "AppUsers");

            migrationBuilder.AlterColumn<int>(
                name: "FacilityId",
                table: "AppUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Facilities_FacilityId",
                table: "AppUsers",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Facilities_FacilityId",
                table: "AppUsers");

            migrationBuilder.AlterColumn<int>(
                name: "FacilityId",
                table: "AppUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Facilities_FacilityId",
                table: "AppUsers",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
