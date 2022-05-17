﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VMS.Server.Data;

namespace VMS.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220517115055_AddVaccineInfo")]
    partial class AddVaccineInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VMS.Shared.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("admin_info");
                });

            modelBuilder.Entity("VMS.Shared.Appoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityBarangay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VaccDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("appointment_info");
                });

            modelBuilder.Entity("VMS.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("user_info");
                });

            modelBuilder.Entity("VMS.Shared.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barangay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstBatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FirstDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstLot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstVaccinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondBatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondVaccinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vaccine_info");
                });

            modelBuilder.Entity("VMS.Shared.Verify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VaccImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaccImgName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("verify_info");
                });
#pragma warning restore 612, 618
        }
    }
}
