﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTracker.Server.Data;

#nullable disable

namespace TimeTracker.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231110163509_CreateInitial")]
    partial class CreateInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeTracker.Shared.RecordData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkEndTimeAfternoon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkEndTimeMorning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStartTimeAfternoon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStartTimeMorning")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RecordDatas");
                });
#pragma warning restore 612, 618
        }
    }
}