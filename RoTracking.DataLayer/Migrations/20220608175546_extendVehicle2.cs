using Microsoft.EntityFrameworkCore.Migrations;

namespace RoTracking.DataLayer.Migrations
{
    public partial class extendVehicle2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Branc",
                table: "Vehicles",
                newName: "Brand");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Vehicles",
                newName: "Branc");
        }
    }
}
