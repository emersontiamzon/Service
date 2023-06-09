﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prechart.Service.Minimumloon.Database.Context;

#nullable disable

namespace Prechart.Service.Minimumloon.Migrations
{
    [DbContext(typeof(MinimumloonDBContext))]
    partial class MinimumloonDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prechart.Service.Minimumloon.Database.Models.Minimumloon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Jaar")
                        .HasColumnType("int");

                    b.Property<decimal>("MinimumloonLeeftijd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerDag")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerMaand")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerUur36")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerUur38")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerUur40")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumloonPerWeek")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("MinimumloonRecordActief")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MinimumloonRecordActiefTot")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("MinimumloonRecordActiefVanaf")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Minimumloon");
                });
#pragma warning restore 612, 618
        }
    }
}
