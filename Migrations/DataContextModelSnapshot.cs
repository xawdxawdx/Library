﻿// <auto-generated />
using System;
using DanilaWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanilaWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DanilaWebApp.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalLocation");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<bool>("SelfExport");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DanilaWebApp.Models.CommunicationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommunicationName");

                    b.Property<string>("CommunicationSubType");

                    b.HasKey("Id");

                    b.ToTable("CommunicationTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommunicationName = "4G",
                            CommunicationSubType = "IMT Advanced"
                        },
                        new
                        {
                            Id = 2,
                            CommunicationName = "4G",
                            CommunicationSubType = "LTE Advanced Pro"
                        },
                        new
                        {
                            Id = 3,
                            CommunicationName = "3G",
                            CommunicationSubType = "LTE"
                        });
                });

            modelBuilder.Entity("DanilaWebApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("ContactPhone");

                    b.Property<int>("ProfileId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DanilaWebApp.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CharacteristicId");

                    b.Property<string>("Company");

                    b.Property<int>("OrderId");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CharacteristicId")
                        .IsUnique();

                    b.HasIndex("OrderId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("DanilaWebApp.Models.PhoneCharacteristic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CpuModel");

                    b.Property<int>("PhoneDepth");

                    b.Property<int>("PhoneHeight");

                    b.Property<int>("PhoneWidth");

                    b.Property<string>("ScreenType");

                    b.Property<string>("opSystem");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.ToTable("PhoneCharacteristics");
                });

            modelBuilder.Entity("DanilaWebApp.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("DanilaWebApp.Models.SupportedCommunicationType", b =>
                {
                    b.Property<int>("CommunicationTypeId");

                    b.Property<int>("PhoneCharacteristicId");

                    b.Property<int>("Id");

                    b.HasKey("CommunicationTypeId", "PhoneCharacteristicId");

                    b.HasIndex("PhoneCharacteristicId");

                    b.ToTable("SupportedCommunicationTypes");
                });

            modelBuilder.Entity("DanilaWebApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<DateTime>("RegistrationDate");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DanilaWebApp.Models.Order", b =>
                {
                    b.HasOne("DanilaWebApp.Models.Address", "Address")
                        .WithOne("Order")
                        .HasForeignKey("DanilaWebApp.Models.Order", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DanilaWebApp.Models.Profile", "Profile")
                        .WithOne("Order")
                        .HasForeignKey("DanilaWebApp.Models.Order", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DanilaWebApp.Models.Phone", b =>
                {
                    b.HasOne("DanilaWebApp.Models.PhoneCharacteristic", "Characteristic")
                        .WithOne("Phone")
                        .HasForeignKey("DanilaWebApp.Models.Phone", "CharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DanilaWebApp.Models.Order", "Order")
                        .WithMany("Phones")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DanilaWebApp.Models.Profile", b =>
                {
                    b.HasOne("DanilaWebApp.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("DanilaWebApp.Models.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DanilaWebApp.Models.SupportedCommunicationType", b =>
                {
                    b.HasOne("DanilaWebApp.Models.CommunicationType", "CommunicationType")
                        .WithMany("SupportedCommunicationTypes")
                        .HasForeignKey("CommunicationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DanilaWebApp.Models.PhoneCharacteristic", "PhoneCharacteristic")
                        .WithMany("SupportedCommunicationTypes")
                        .HasForeignKey("PhoneCharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
