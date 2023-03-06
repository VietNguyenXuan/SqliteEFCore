﻿// <auto-generated />
using System;
using DemoSQLite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoSQLite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230306145854_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DemoSQLite.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MachineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("DemoSQLite.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("DemoSQLite.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("DemoSQLite.Models.Device", b =>
                {
                    b.HasOne("DemoSQLite.Models.Machine", "Machine")
                        .WithMany("Devices")
                        .HasForeignKey("MachineId");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("DemoSQLite.Models.Machine", b =>
                {
                    b.HasOne("DemoSQLite.Models.Line", "Line")
                        .WithMany("Machines")
                        .HasForeignKey("LineId");

                    b.Navigation("Line");
                });

            modelBuilder.Entity("DemoSQLite.Models.Line", b =>
                {
                    b.Navigation("Machines");
                });

            modelBuilder.Entity("DemoSQLite.Models.Machine", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}