using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoTracking.DataLayer.Migrations
{
    public partial class initialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDriver = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mileage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceDriverConnections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConnectionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConnectionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDriverConnections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceDriverConnections_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceDriverConnections_Persons_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceVehicleConnection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConnectionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConnectionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceVehicleConnection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceVehicleConnection_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceVehicleConnection_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleConnection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConnectionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConnectionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleConnection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverVehicleConnection_Persons_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriverVehicleConnection_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDriverConnections_DeviceId",
                table: "DeviceDriverConnections",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDriverConnections_DriverId",
                table: "DeviceDriverConnections",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceVehicleConnection_DeviceId",
                table: "DeviceVehicleConnection",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceVehicleConnection_VehicleId",
                table: "DeviceVehicleConnection",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleConnection_DriverId",
                table: "DriverVehicleConnection",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleConnection_VehicleId",
                table: "DriverVehicleConnection",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceDriverConnections");

            migrationBuilder.DropTable(
                name: "DeviceVehicleConnection");

            migrationBuilder.DropTable(
                name: "DriverVehicleConnection");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
