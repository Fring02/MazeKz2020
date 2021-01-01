﻿// <auto-generated />
using System;
using Housing.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Housing.Infrastructure.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20210101171034_AddApplyStatusForRequests")]
    partial class AddApplyStatusForRequests
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Housing.Core.Models.CartHouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("OwnerId");

                    b.ToTable("HouseCarts");
                });

            modelBuilder.Entity("Housing.Core.Models.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LeavedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("HouseId");

                    b.HasIndex("UserId");

                    b.ToTable("HouseAdvertisementComments");
                });

            modelBuilder.Entity("Housing.Core.Models.House", b =>
                {
                    b.Property<long>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSelling")
                        .HasColumnType("bit");

                    b.Property<int>("MaxResidentsCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("HouseId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingOwner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HouseOwners");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingOwnerRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsApplied")
                        .HasColumnType("bit");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("OwnerId");

                    b.ToTable("HousingOwnerRequests");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingResident", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("HouseResidents");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingResidentRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsApplied")
                        .HasColumnType("bit");

                    b.Property<long>("ResidentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("ResidentId");

                    b.ToTable("HousingResidentRequests");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.CitizenUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Housing.Core.Models.CartHouse", b =>
                {
                    b.HasOne("Housing.Core.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Housing.Core.Models.HousingOwner", "Owner")
                        .WithMany("CartHouses")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Housing.Core.Models.Comment", b =>
                {
                    b.HasOne("Housing.Core.Models.House", "House")
                        .WithMany("Comments")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Housing.Core.Models.HousingResident", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Housing.Core.Models.House", b =>
                {
                    b.HasOne("Housing.Core.Models.HousingOwner", "Owner")
                        .WithMany("Houses")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingOwner", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingOwnerRequest", b =>
                {
                    b.HasOne("Housing.Core.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Housing.Core.Models.HousingOwner", "Owner")
                        .WithMany("OwnerRequests")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingResident", b =>
                {
                    b.HasOne("Housing.Core.Models.House", "House")
                        .WithMany("HousingUsers")
                        .HasForeignKey("HouseId");

                    b.HasOne("Housing.Core.Models.HousingOwner", "Owner")
                        .WithOne("HousingUser")
                        .HasForeignKey("Housing.Core.Models.HousingResident", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingResidentRequest", b =>
                {
                    b.HasOne("Housing.Core.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Housing.Core.Models.HousingResident", "Resident")
                        .WithMany("ResidentRequests")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Housing.Core.Models.House", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("HousingUsers");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingOwner", b =>
                {
                    b.Navigation("CartHouses");

                    b.Navigation("Houses");

                    b.Navigation("HousingUser");

                    b.Navigation("OwnerRequests");
                });

            modelBuilder.Entity("Housing.Core.Models.HousingResident", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ResidentRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
