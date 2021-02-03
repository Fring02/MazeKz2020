﻿// <auto-generated />
using System;
using Housing.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Housing.Infrastructure.Migrations
{
    [DbContext(typeof(HousingContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CitizenUserPoliceCertificate", b =>
                {
                    b.Property<long>("PoliceCertificatesId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("PoliceCertificatesId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CitizenUserPoliceCertificate");
                });

            modelBuilder.Entity("CitizenUserRole", b =>
                {
                    b.Property<long>("RolesId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersId")
                        .HasColumnType("bigint");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("CitizenUserRole");
                });

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

            modelBuilder.Entity("WebMaze.DbStuff.Model.Adress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<long?>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.CitizenUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HaveChildren")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDead")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Marriage")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.MedicalInsurance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<decimal>("Coast")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndPeriod")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HaveChildren")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMaried")
                        .HasColumnType("bit");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartPeriod")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("MedicalInsurance");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.MedicineCertificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateExpiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("MedicineCertificate");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.RecordForm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CitizenIdId")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenIdId");

                    b.ToTable("RecordForm");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Police.PoliceCertificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Validity")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PoliceCertificate");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.UserAccount.Certificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IssuedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("CitizenUserPoliceCertificate", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.Police.PoliceCertificate", null)
                        .WithMany()
                        .HasForeignKey("PoliceCertificatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CitizenUserRole", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("WebMaze.DbStuff.Model.Adress", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "Owner")
                        .WithMany("Adresses")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.MedicalInsurance", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "Owner")
                        .WithOne("MedicalInsurance")
                        .HasForeignKey("WebMaze.DbStuff.Model.Medicine.MedicalInsurance", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.MedicineCertificate", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "User")
                        .WithOne("MedicineCertificate")
                        .HasForeignKey("WebMaze.DbStuff.Model.Medicine.MedicineCertificate", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.Medicine.RecordForm", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "CitizenId")
                        .WithMany("RecordForms")
                        .HasForeignKey("CitizenIdId");

                    b.Navigation("CitizenId");
                });

            modelBuilder.Entity("WebMaze.DbStuff.Model.UserAccount.Certificate", b =>
                {
                    b.HasOne("WebMaze.DbStuff.Model.CitizenUser", "Owner")
                        .WithMany("Certificates")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
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

            modelBuilder.Entity("WebMaze.DbStuff.Model.CitizenUser", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("Certificates");

                    b.Navigation("MedicalInsurance");

                    b.Navigation("MedicineCertificate");

                    b.Navigation("RecordForms");
                });
#pragma warning restore 612, 618
        }
    }
}
