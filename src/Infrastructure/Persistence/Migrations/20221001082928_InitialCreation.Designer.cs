// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SaleReporting.Infrastructure.Persistence;

#nullable disable

namespace SaleReporting.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221001082928_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SaleReporting.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("COGS")
                        .HasColumnType("double precision");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATE")
                        .HasColumnName("SaleDate");

                    b.Property<int>("DiscountBand")
                        .HasColumnType("integer");

                    b.Property<double>("Discounts")
                        .HasColumnType("double precision");

                    b.Property<double>("GrossSales")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<double>("ManufacturingPrice")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<double>("Profit")
                        .HasColumnType("double precision");

                    b.Property<double>("SalePrice")
                        .HasColumnType("double precision");

                    b.Property<double>("Sales")
                        .HasColumnType("double precision");

                    b.Property<int>("SegmentId")
                        .HasColumnType("integer");

                    b.Property<double>("SoldUnits")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SegmentId");

                    b.ToTable("Sales", (string)null);
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Segments", (string)null);
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Sale", b =>
                {
                    b.HasOne("SaleReporting.Domain.Entities.Country", "Country")
                        .WithMany("Sales")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleReporting.Domain.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleReporting.Domain.Entities.Segment", "Segment")
                        .WithMany("Sales")
                        .HasForeignKey("SegmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Product");

                    b.Navigation("Segment");
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Country", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Product", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SaleReporting.Domain.Entities.Segment", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
