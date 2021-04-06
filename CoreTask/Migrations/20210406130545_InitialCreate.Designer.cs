﻿// <auto-generated />
using System;
using CoreTask.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreTask.Migrations
{
    [DbContext(typeof(TaskDBContext))]
    [Migration("20210406130545_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreTask.Domain.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CoreTask.Domain.Sales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CoreTask.Domain.Visits", b =>
                {
                    b.Property<int>("Serial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("SalesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("Date");

                    b.Property<string>("VisitSummary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Serial");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SalesID");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("CoreTask.Domain.Visits", b =>
                {
                    b.HasOne("CoreTask.Domain.Customer", "customer")
                        .WithMany("visits")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("CoreTask.Domain.Sales", "sales")
                        .WithMany("visits")
                        .HasForeignKey("SalesID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("sales");
                });

            modelBuilder.Entity("CoreTask.Domain.Customer", b =>
                {
                    b.Navigation("visits");
                });

            modelBuilder.Entity("CoreTask.Domain.Sales", b =>
                {
                    b.Navigation("visits");
                });
#pragma warning restore 612, 618
        }
    }
}
