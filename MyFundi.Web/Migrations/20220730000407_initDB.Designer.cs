﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFundi.DataAccess;

namespace MyFundi.Web.Migrations
{
    [DbContext(typeof(MyFundiDBContext))]
    [Migration("20220730000407_initDB")]
    partial class initDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFundi.Domain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MyFundi.Domain.Certification", b =>
                {
                    b.Property<int>("CertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("CertificationId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("MyFundi.Domain.ClientFundiContract", b =>
                {
                    b.Property<int>("ClientFundiContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AgreedCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ClientUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractualDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FundiUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSignedOffByClient")
                        .HasColumnType("bit");

                    b.Property<string>("NotesForNotice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NumberOfDaysToComplete")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ClientFundiContractId");

                    b.HasIndex("ClientUserId");

                    b.HasIndex("FundiUserId");

                    b.ToTable("ClientFundiContracts");
                });

            modelBuilder.Entity("MyFundi.Domain.ClientProfile", b =>
                {
                    b.Property<int>("ClientProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientProfileId");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("ClientProfiles");
                });

            modelBuilder.Entity("MyFundi.Domain.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhoneNUmber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.HasIndex("LocationId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MyFundi.Domain.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfile", b =>
                {
                    b.Property<int>("FundiProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FundiProfileCvUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsedPowerTools")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FundiProfileId");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("FundiProfiles");
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfileCertification", b =>
                {
                    b.Property<int>("FundiProfileCertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CertificationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundiProfileId")
                        .HasColumnType("int");

                    b.HasKey("FundiProfileCertificationId");

                    b.HasIndex("CertificationId");

                    b.HasIndex("FundiProfileId");

                    b.ToTable("FundiProfileCertifications");
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfileCourseTaken", b =>
                {
                    b.Property<int>("FundiProfileCourseTakenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundiProfileId")
                        .HasColumnType("int");

                    b.HasKey("FundiProfileCourseTakenId");

                    b.HasIndex("CourseId");

                    b.HasIndex("FundiProfileId");

                    b.ToTable("FundiProfileCourses");
                });

            modelBuilder.Entity("MyFundi.Domain.FundiRatingAndReview", b =>
                {
                    b.Property<int>("FundiRatingAndReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundiProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkCategoryType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FundiRatingAndReviewId");

                    b.HasIndex("FundiProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("FundiProfileAndReviewRatings");
                });

            modelBuilder.Entity("MyFundi.Domain.FundiWorkCategory", b =>
                {
                    b.Property<int>("FundiWorkCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundiProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("WorkCategoryId")
                        .HasColumnType("int");

                    b.HasKey("FundiWorkCategoryId");

                    b.HasIndex("FundiProfileId");

                    b.HasIndex("WorkCategoryId");

                    b.ToTable("FundiWorkCategories");
                });

            modelBuilder.Entity("MyFundi.Domain.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GrossCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("HasFullyPaid")
                        .HasColumnType("bit");

                    b.Property<string>("InvoiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NetCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PercentTaxAppliable")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InvoiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("MyFundi.Domain.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MyFundi.Domain.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedFundiProfileId")
                        .HasColumnType("int");

                    b.Property<Guid?>("AssignedFundiUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ClientFundiContractId")
                        .HasColumnType("int");

                    b.Property<int>("ClientProfileId")
                        .HasColumnType("int");

                    b.Property<Guid>("ClientUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasBeenAssignedFundi")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDaysToComplete")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.HasIndex("AssignedFundiProfileId");

                    b.HasIndex("AssignedFundiUserId");

                    b.HasIndex("ClientProfileId");

                    b.HasIndex("ClientUserId");

                    b.HasIndex("LocationId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("MyFundi.Domain.JobWorkCategory", b =>
                {
                    b.Property<int>("JobWorkCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkCategoryId")
                        .HasColumnType("int");

                    b.HasKey("JobWorkCategoryId");

                    b.HasIndex("JobId");

                    b.HasIndex("WorkCategoryId");

                    b.ToTable("JobWorkCategories");
                });

            modelBuilder.Entity("MyFundi.Domain.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsGeocoded")
                        .HasColumnType("bit");

                    b.Property<float?>("Latitude")
                        .HasColumnType("real");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Longitude")
                        .HasColumnType("real");

                    b.HasKey("LocationId");

                    b.HasIndex("AddressId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MyFundi.Domain.MonthlySubscription", b =>
                {
                    b.Property<int>("MonthlySubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FundiProfileId")
                        .HasColumnType("int");

                    b.Property<bool>("HasPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubscriptionDescritption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubscriptionFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SubscriptonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonthlySubscriptionId");

                    b.HasIndex("FundiProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("MonthlySubscriptions");
                });

            modelBuilder.Entity("MyFundi.Domain.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleName")
                        .IsUnique()
                        .HasFilter("[RoleName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MyFundi.Domain.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLockedOut")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogInTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasAlternateKey("Username");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyFundi.Domain.UserRole", b =>
                {
                    b.Property<Guid>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserRoleId");

                    b.HasAlternateKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MyFundi.Domain.WorkCategory", b =>
                {
                    b.Property<int>("WorkCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkCategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCategoryType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkCategoryId");

                    b.ToTable("WorkCategories");
                });

            modelBuilder.Entity("MyFundi.Domain.ClientFundiContract", b =>
                {
                    b.HasOne("MyFundi.Domain.User", "ClientUser")
                        .WithMany()
                        .HasForeignKey("ClientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "FundiUser")
                        .WithMany()
                        .HasForeignKey("FundiUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.ClientProfile", b =>
                {
                    b.HasOne("MyFundi.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.Company", b =>
                {
                    b.HasOne("MyFundi.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfile", b =>
                {
                    b.HasOne("MyFundi.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfileCertification", b =>
                {
                    b.HasOne("MyFundi.Domain.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("CertificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.FundiProfile", "FundiProfile")
                        .WithMany()
                        .HasForeignKey("FundiProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.FundiProfileCourseTaken", b =>
                {
                    b.HasOne("MyFundi.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.FundiProfile", "FundiProfile")
                        .WithMany()
                        .HasForeignKey("FundiProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.FundiRatingAndReview", b =>
                {
                    b.HasOne("MyFundi.Domain.FundiProfile", "FundiProfile")
                        .WithMany()
                        .HasForeignKey("FundiProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.FundiWorkCategory", b =>
                {
                    b.HasOne("MyFundi.Domain.FundiProfile", "FundiProfile")
                        .WithMany()
                        .HasForeignKey("FundiProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.WorkCategory", "WorkCategory")
                        .WithMany()
                        .HasForeignKey("WorkCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.Invoice", b =>
                {
                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.Item", b =>
                {
                    b.HasOne("MyFundi.Domain.Invoice", "Invoice")
                        .WithMany("InvoicedItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.Job", b =>
                {
                    b.HasOne("MyFundi.Domain.FundiProfile", "AssignedFundiProfile")
                        .WithMany()
                        .HasForeignKey("AssignedFundiProfileId");

                    b.HasOne("MyFundi.Domain.User", "AssignedFundiUser")
                        .WithMany()
                        .HasForeignKey("AssignedFundiUserId");

                    b.HasOne("MyFundi.Domain.ClientProfile", "ClientProfile")
                        .WithMany()
                        .HasForeignKey("ClientProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "ClientUser")
                        .WithMany()
                        .HasForeignKey("ClientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.JobWorkCategory", b =>
                {
                    b.HasOne("MyFundi.Domain.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId");

                    b.HasOne("MyFundi.Domain.WorkCategory", "WorkCategory")
                        .WithMany()
                        .HasForeignKey("WorkCategoryId");
                });

            modelBuilder.Entity("MyFundi.Domain.Location", b =>
                {
                    b.HasOne("MyFundi.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFundi.Domain.MonthlySubscription", b =>
                {
                    b.HasOne("MyFundi.Domain.FundiProfile", "FundiProfile")
                        .WithMany()
                        .HasForeignKey("FundiProfileId");

                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MyFundi.Domain.User", b =>
                {
                    b.HasOne("MyFundi.Domain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("MyFundi.Domain.UserRole", b =>
                {
                    b.HasOne("MyFundi.Domain.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFundi.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
