﻿// <auto-generated />
using System;
using IoTProductionLineMonitoring.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IoTProductionLineMonitoring.Migrations
{
    [DbContext(typeof(IoTProductionLineMonitoringContext))]
    partial class IoTProductionLineMonitoringContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.ProductionLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductionLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Location1",
                            Name = "Line1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Location2",
                            Name = "Line2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Location3",
                            Name = "Line3"
                        });
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductionLineId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductionLineId");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TempSensor1",
                            ProductionLineId = 1,
                            Type = "Temperature"
                        },
                        new
                        {
                            Id = 2,
                            Name = "VibSensor1",
                            ProductionLineId = 1,
                            Type = "Vibration"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TempSensor2",
                            ProductionLineId = 2,
                            Type = "Temperature"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PowerSensor1",
                            ProductionLineId = 2,
                            Type = "Power"
                        },
                        new
                        {
                            Id = 5,
                            Name = "EnergySensor1",
                            ProductionLineId = 3,
                            Type = "Energy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "TempSensor3",
                            ProductionLineId = 3,
                            Type = "Temperature"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VibSensor2",
                            ProductionLineId = 3,
                            Type = "Vibration"
                        });
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.SensorData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("SensorData");
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.Sensor", b =>
                {
                    b.HasOne("IoTProductionLineMonitoring.Models.ProductionLine", "ProductionLine")
                        .WithMany("Sensors")
                        .HasForeignKey("ProductionLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductionLine");
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.SensorData", b =>
                {
                    b.HasOne("IoTProductionLineMonitoring.Models.Sensor", "Sensor")
                        .WithMany("SensorData")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensor");
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.ProductionLine", b =>
                {
                    b.Navigation("Sensors");
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.Sensor", b =>
                {
                    b.Navigation("SensorData");
                });
#pragma warning restore 612, 618
        }
    }
}
