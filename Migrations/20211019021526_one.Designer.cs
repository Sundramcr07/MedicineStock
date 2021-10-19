﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockWithDatabase.Models;

namespace StockWithDatabase.Migrations
{
    [DbContext(typeof(MedicineStockContext))]
    [Migration("20211019021526_one")]
    partial class one
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockWithDatabase.Models.MedicineStock", b =>
                {
                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChemicalComposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfTabletsInStock")
                        .HasColumnType("int");

                    b.Property<string>("TargetAilment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineName");

                    b.ToTable("MedicineStock");

                    b.HasData(
                        new
                        {
                            MedicineName = "Dolo 650",
                            ChemicalComposition = "Paracetamol,Acetaminophen",
                            DateOfExpiry = new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 300,
                            TargetAilment = "General"
                        },
                        new
                        {
                            MedicineName = "Orthoherb",
                            ChemicalComposition = "Castor Plant,Adulsa,Neem,Guggul",
                            DateOfExpiry = new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 190,
                            TargetAilment = "Orthopaedics"
                        },
                        new
                        {
                            MedicineName = "Cholecalciferol",
                            ChemicalComposition = "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol",
                            DateOfExpiry = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 200,
                            TargetAilment = "Orthopaedics"
                        },
                        new
                        {
                            MedicineName = "Gaviscon",
                            ChemicalComposition = "Magnesium,Oxide,Silicon,Sodium",
                            DateOfExpiry = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 150,
                            TargetAilment = "General"
                        },
                        new
                        {
                            MedicineName = "Hilact",
                            ChemicalComposition = "Pancreatin,Dimethicone,Polydimethylsiloxane",
                            DateOfExpiry = new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 400,
                            TargetAilment = "Gynaecology"
                        },
                        new
                        {
                            MedicineName = "Cyclopam",
                            ChemicalComposition = "Dicyclomine,Hydrochloride,Paracetamol",
                            DateOfExpiry = new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 500,
                            TargetAilment = "Gynaecology"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}