﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DataContex;

namespace Project.Migrations
{
    [DbContext(typeof(Aplication))]
    [Migration("20210820141528_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project.Models.Entities.Client", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayMethod")
                        .HasColumnType("int");

                    b.HasKey("PhoneNumber");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Project.Models.Entities.Doctor", b =>
                {
                    b.Property<string>("License")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Cabinet")
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorStatus")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("License");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Project.Models.Entities.Order", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientPhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DoctorLicense")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Problem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ClientPhoneNumber");

                    b.HasIndex("DoctorLicense");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project.Models.Entities.Order", b =>
                {
                    b.HasOne("Project.Models.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientPhoneNumber");

                    b.HasOne("Project.Models.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorLicense");

                    b.Navigation("Client");

                    b.Navigation("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}