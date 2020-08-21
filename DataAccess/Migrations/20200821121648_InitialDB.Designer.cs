﻿// <auto-generated />
using System;
using DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SolarInstalationDbContext))]
    [Migration("20200821121648_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Entities.Inverter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MaximumPower")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inverter");
                });

            modelBuilder.Entity("Model.Entities.PvPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PanelLength")
                        .HasColumnType("real");

                    b.Property<float>("PanelWidth")
                        .HasColumnType("real");

                    b.Property<double>("Power")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PvPanel");
                });

            modelBuilder.Entity("Model.Entities.PvSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InverterId")
                        .HasColumnType("int");

                    b.Property<float>("MountingAngle")
                        .HasColumnType("real");

                    b.Property<string>("MountingDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPvPanels")
                        .HasColumnType("int");

                    b.Property<int?>("PvPanelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InverterId");

                    b.HasIndex("PvPanelId");

                    b.ToTable("PvSystem");
                });

            modelBuilder.Entity("Model.Entities.PvSystem", b =>
                {
                    b.HasOne("Model.Entities.Inverter", "Inverter")
                        .WithMany()
                        .HasForeignKey("InverterId");

                    b.HasOne("Model.Entities.PvPanel", "PvPanel")
                        .WithMany()
                        .HasForeignKey("PvPanelId");
                });
#pragma warning restore 612, 618
        }
    }
}