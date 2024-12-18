﻿// <auto-generated />
using System;
using IoTProductionLineMonitoring.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IoTProductionLineMonitoring.Migrations
{
    [DbContext(typeof(IoTProductionLineMonitoringContext))]
    [Migration("20241201162651_DataSeed-Sensors")]
    partial class DataSeedSensors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TempSensor1",
                            Type = "Temperature"
                        },
                        new
                        {
                            Id = 2,
                            Name = "VibSensor1",
                            Type = "Vibration"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TempSensor2",
                            Type = "Temperature"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PowerSensor1",
                            Type = "Power"
                        },
                        new
                        {
                            Id = 5,
                            Name = "EnergySensor1",
                            Type = "Energy"
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

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.SensorData", b =>
                {
                    b.HasOne("IoTProductionLineMonitoring.Models.Sensor", "Sensor")
                        .WithMany("SensorData")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensor");
                });

            modelBuilder.Entity("IoTProductionLineMonitoring.Models.Sensor", b =>
                {
                    b.Navigation("SensorData");
                });
#pragma warning restore 612, 618
        }
    }
}
