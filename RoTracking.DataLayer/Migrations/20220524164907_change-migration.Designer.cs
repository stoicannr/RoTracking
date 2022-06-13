﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoTracking.DataLayer.Context;

namespace RoTracking.DataLayer.Migrations
{
    [DbContext(typeof(RoTrackingDbContext))]
    [Migration("20220524164907_change-migration")]
    partial class changemigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoTracking.DataLayer.Models.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DeviceDriverConnection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ConnectionEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConnectionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("DriverId");

                    b.ToTable("DeviceDriverConnections");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DeviceVehicleConnection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ConnectionEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConnectionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("VehicleId");

                    b.ToTable("DeviceVehicleConnection");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DriverVehicleConnection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ConnectionEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConnectionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("DriverVehicleConnection");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Mileage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DeviceDriverConnection", b =>
                {
                    b.HasOne("RoTracking.DataLayer.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.HasOne("RoTracking.DataLayer.Models.Person", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.Navigation("Device");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DeviceVehicleConnection", b =>
                {
                    b.HasOne("RoTracking.DataLayer.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.HasOne("RoTracking.DataLayer.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("Device");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("RoTracking.DataLayer.Models.DriverVehicleConnection", b =>
                {
                    b.HasOne("RoTracking.DataLayer.Models.Person", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("RoTracking.DataLayer.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("Driver");

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
