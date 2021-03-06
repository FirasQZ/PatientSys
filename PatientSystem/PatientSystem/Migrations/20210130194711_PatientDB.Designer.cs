﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientSystem.DBContext;

namespace PatientSystem.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210130194711_PatientDB")]
    partial class PatientDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatientSystem.Models.Classes.Patient", b =>
                {
                    b.Property<int>("Patient_Seq_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Patient_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Patient_DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Patient_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Patient_id")
                        .HasColumnType("int");

                    b.HasKey("Patient_Seq_id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("PatientSystem.Models.Classes.PatientEntry", b =>
                {
                    b.Property<int>("entry_Seq")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disease_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Entry_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mony_ammount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Patient_Seq_id")
                        .HasColumnType("int");

                    b.Property<int>("patient_Id")
                        .HasColumnType("int");

                    b.HasKey("entry_Seq");

                    b.HasIndex("Patient_Seq_id");

                    b.ToTable("PatientEntry");
                });

            modelBuilder.Entity("PatientSystem.Models.Classes.PatientEntry", b =>
                {
                    b.HasOne("PatientSystem.Models.Classes.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("Patient_Seq_id");
                });
#pragma warning restore 612, 618
        }
    }
}
