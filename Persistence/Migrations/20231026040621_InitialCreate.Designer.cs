﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231026040621_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Domain.Item", b =>
                {
                    b.Property<string>("Sku")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkuAlias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vendor")
                        .HasColumnType("TEXT");

                    b.HasKey("Sku");

                    b.ToTable("Items");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Domain.Bearing", b =>
                {
                    b.HasBaseType("Domain.Item");

                    b.Property<string>("BoreType")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Flange")
                        .HasColumnType("INTEGER");

                    b.Property<double>("InnerDiameter")
                        .HasColumnType("REAL");

                    b.Property<bool>("Metric")
                        .HasColumnType("INTEGER");

                    b.Property<double>("OuterDiameter")
                        .HasColumnType("REAL");

                    b.Property<double>("Width")
                        .HasColumnType("REAL");

                    b.ToTable("Bearings");
                });

            modelBuilder.Entity("Domain.CustomItem", b =>
                {
                    b.HasBaseType("Domain.Item");

                    b.Property<bool>("Custom")
                        .HasColumnType("INTEGER");

                    b.ToTable("CustomItems");
                });

            modelBuilder.Entity("Domain.Bearing", b =>
                {
                    b.HasOne("Domain.Item", null)
                        .WithOne()
                        .HasForeignKey("Domain.Bearing", "Sku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.CustomItem", b =>
                {
                    b.HasOne("Domain.Item", null)
                        .WithOne()
                        .HasForeignKey("Domain.CustomItem", "Sku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
