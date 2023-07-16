﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReGenerationProjectAssignment_FundRaiser.DbContexts;

#nullable disable

namespace ReGenerationProjectAssignment_FundRaiser.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    [Migration("20230716135812_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Funding_PackageProject", b =>
                {
                    b.Property<int>("Funding_PackagesPackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Funding_PackagesPackageId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Funding_PackageProject");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Funding_Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageId"));

                    b.Property<string>("PackageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageReward")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageValue")
                        .HasColumnType("int");

                    b.Property<int?>("Project_TrackerTrackerId")
                        .HasColumnType("int");

                    b.HasKey("PackageId");

                    b.HasIndex("Project_TrackerTrackerId");

                    b.ToTable("Funding_Packages");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FundingGoal")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Project_TrackerTrackerId")
                        .HasColumnType("int");

                    b.Property<int?>("Status_UpdateStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Project_TrackerTrackerId");

                    b.HasIndex("Status_UpdateStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Project_Tracker", b =>
                {
                    b.Property<int>("TrackerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackerId"));

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.HasKey("TrackerId");

                    b.ToTable("Project_Tracker");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Status_Update", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("StatusId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Status_Updates");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Funding_PackageProject", b =>
                {
                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Funding_Package", null)
                        .WithMany()
                        .HasForeignKey("Funding_PackagesPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Funding_Package", b =>
                {
                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Project_Tracker", null)
                        .WithMany("Funding_Packages")
                        .HasForeignKey("Project_TrackerTrackerId");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Project", b =>
                {
                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Project_Tracker", "Project_Tracker")
                        .WithMany("Project")
                        .HasForeignKey("Project_TrackerTrackerId");

                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Status_Update", null)
                        .WithMany("Projects")
                        .HasForeignKey("Status_UpdateStatusId");

                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("Project_Tracker");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Status_Update", b =>
                {
                    b.HasOne("ReGenerationProjectAssignment_FundRaiser.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Category", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Project_Tracker", b =>
                {
                    b.Navigation("Funding_Packages");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.Status_Update", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ReGenerationProjectAssignment_FundRaiser.Models.User", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
