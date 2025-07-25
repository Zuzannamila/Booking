﻿// <auto-generated />
using System;
using Booking.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Dal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250724193915_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booking.Models.Entities.BaseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Booking.Models.Entities.Client", b =>
                {
                    b.HasBaseType("Booking.Models.Entities.BaseEntity");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Clients", "dbo");
                });

            modelBuilder.Entity("Booking.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("Booking.Models.Entities.BaseEntity");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("VenueId");

                    b.ToTable("Employees", "dbo");
                });

            modelBuilder.Entity("Booking.Models.Entities.Service", b =>
                {
                    b.HasBaseType("Booking.Models.Entities.BaseEntity");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("VenueId");

                    b.ToTable("Services", "dbo");
                });

            modelBuilder.Entity("Booking.Models.Entities.Venue", b =>
                {
                    b.HasBaseType("Booking.Models.Entities.BaseEntity");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("Venues", "dbo");
                });

            modelBuilder.Entity("Booking.Models.Entities.Visit", b =>
                {
                    b.HasBaseType("Booking.Models.Entities.BaseEntity");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("VenueId");

                    b.ToTable("Visits", "dbo");
                });

            modelBuilder.Entity("Booking.Models.Entities.Employee", b =>
                {
                    b.HasOne("Booking.Models.Entities.Venue", "VenueNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("Booking.Models.Entities.Owned.EmployeeSchedule", "Schedules", b1 =>
                        {
                            b1.Property<Guid>("EmployeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.HasKey("EmployeeId", "Id");

                            b1.ToTable("EmployeeSchedules", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");

                            b1.OwnsOne("Booking.Models.Entities.Owned.OpeningHours", "Availability", b2 =>
                                {
                                    b2.Property<Guid>("EmployeeScheduleEmployeeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("EmployeeScheduleId")
                                        .HasColumnType("int");

                                    b2.Property<int>("Day")
                                        .HasColumnType("int");

                                    b2.Property<TimeSpan>("End")
                                        .HasColumnType("time");

                                    b2.Property<TimeSpan>("Start")
                                        .HasColumnType("time");

                                    b2.HasKey("EmployeeScheduleEmployeeId", "EmployeeScheduleId");

                                    b2.ToTable("EmployeeSchedules", "dbo");

                                    b2.WithOwner()
                                        .HasForeignKey("EmployeeScheduleEmployeeId", "EmployeeScheduleId");
                                });

                            b1.Navigation("Availability");
                        });

                    b.Navigation("Schedules");

                    b.Navigation("VenueNavigation");
                });

            modelBuilder.Entity("Booking.Models.Entities.Service", b =>
                {
                    b.HasOne("Booking.Models.Entities.Venue", "VenueNavigation")
                        .WithMany("Services")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VenueNavigation");
                });

            modelBuilder.Entity("Booking.Models.Entities.Venue", b =>
                {
                    b.OwnsOne("Booking.Models.Entities.Owned.Address", "AddressInformation", b1 =>
                        {
                            b1.Property<Guid>("VenueId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("StateOrProvince")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("Unit")
                                .HasColumnType("int");

                            b1.HasKey("VenueId");

                            b1.ToTable("Addresses", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("VenueId");
                        });

                    b.OwnsMany("Booking.Models.Entities.Owned.VenuePhoto", "VenuePhotos", b1 =>
                        {
                            b1.Property<Guid>("VenueId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("AltText")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Caption")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("SortOrder")
                                .HasColumnType("int");

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("VenueId", "Id");

                            b1.ToTable("Photos", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("VenueId");
                        });

                    b.OwnsMany("Booking.Models.Entities.Owned.OpeningHours", "OpeningHours", b1 =>
                        {
                            b1.Property<Guid>("VenueId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<int>("Day")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("End")
                                .HasColumnType("time");

                            b1.Property<TimeSpan>("Start")
                                .HasColumnType("time");

                            b1.HasKey("VenueId", "Id");

                            b1.ToTable("Venues_OpeningHours", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("VenueId");
                        });

                    b.Navigation("AddressInformation")
                        .IsRequired();

                    b.Navigation("OpeningHours");

                    b.Navigation("VenuePhotos");
                });

            modelBuilder.Entity("Booking.Models.Entities.Visit", b =>
                {
                    b.HasOne("Booking.Models.Entities.Client", "ClientNavigation")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Models.Entities.Employee", "EmployeeNavigation")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Booking.Models.Entities.Service", "ServiceNavigation")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Booking.Models.Entities.Venue", "VenueNavigation")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ClientNavigation");

                    b.Navigation("EmployeeNavigation");

                    b.Navigation("ServiceNavigation");

                    b.Navigation("VenueNavigation");
                });

            modelBuilder.Entity("Booking.Models.Entities.Venue", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
