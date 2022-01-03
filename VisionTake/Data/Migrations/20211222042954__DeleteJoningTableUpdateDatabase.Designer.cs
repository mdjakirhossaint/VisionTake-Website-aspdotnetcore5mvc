﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisionTake.Data;

namespace VisionTake.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211222042954__DeleteJoningTableUpdateDatabase")]
    partial class _DeleteJoningTableUpdateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VisionTake.Entities.AboutPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblAboutID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblAboutID");

                    b.HasIndex("TblPictureID");

                    b.ToTable("AboutPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.CategoryPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblCategoryID");

                    b.HasIndex("TblPictureID");

                    b.ToTable("CategoryPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.CategorySubCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TblCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblSubCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblCategoryID");

                    b.HasIndex("TblSubCategoryID");

                    b.ToTable("CategorySubCategories");
                });

            modelBuilder.Entity("VisionTake.Entities.EventPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblEventID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblEventID");

                    b.HasIndex("TblPictureID");

                    b.ToTable("EventPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.NewsPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblNewsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblNewsID");

                    b.HasIndex("TblPictureID");

                    b.ToTable("NewsPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.PartnerPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPartnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblPartnerID");

                    b.HasIndex("TblPictureID");

                    b.ToTable("PartnerPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.ProductPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblPictureID");

                    b.HasIndex("TblProductID");

                    b.ToTable("ProductPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.SliderPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblSliderID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblPictureID");

                    b.HasIndex("TblSliderID");

                    b.ToTable("SliderPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.SubCategoryPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblPictureID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblSubCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblPictureID");

                    b.HasIndex("TblSubCategoryID");

                    b.ToTable("SubCategoryPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.TagNews", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TblNewsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TblTagID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblNewsID");

                    b.HasIndex("TblTagID");

                    b.ToTable("TagNewses");
                });

            modelBuilder.Entity("VisionTake.Entities.TblAbout", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblAbouts");
                });

            modelBuilder.Entity("VisionTake.Entities.TblAddress", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblAddresses");
                });

            modelBuilder.Entity("VisionTake.Entities.TblCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblCategories");
                });

            modelBuilder.Entity("VisionTake.Entities.TblContact", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblContacts");
                });

            modelBuilder.Entity("VisionTake.Entities.TblEvent", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblEvent");
                });

            modelBuilder.Entity("VisionTake.Entities.TblNews", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("TblNewses");
                });

            modelBuilder.Entity("VisionTake.Entities.TblPartner", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblPartners");
                });

            modelBuilder.Entity("VisionTake.Entities.TblPatent", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblPatents");
                });

            modelBuilder.Entity("VisionTake.Entities.TblPicture", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblPictures");
                });

            modelBuilder.Entity("VisionTake.Entities.TblProduct", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TblCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TblSubCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblCategoryID");

                    b.HasIndex("TblSubCategoryID");

                    b.ToTable("TblProducts");
                });

            modelBuilder.Entity("VisionTake.Entities.TblSlider", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblSliders");
                });

            modelBuilder.Entity("VisionTake.Entities.TblSubCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TblCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TblCategoryID");

                    b.ToTable("TblSubCategories");
                });

            modelBuilder.Entity("VisionTake.Entities.TblTag", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TblTags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VisionTake.Entities.AboutPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblAbout", "TblAbout")
                        .WithMany()
                        .HasForeignKey("TblAboutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblAbout");

                    b.Navigation("TblPicture");
                });

            modelBuilder.Entity("VisionTake.Entities.CategoryPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblCategory", "TblCategory")
                        .WithMany()
                        .HasForeignKey("TblCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblCategory");

                    b.Navigation("TblPicture");
                });

            modelBuilder.Entity("VisionTake.Entities.CategorySubCategory", b =>
                {
                    b.HasOne("VisionTake.Entities.TblCategory", "TblCategory")
                        .WithMany()
                        .HasForeignKey("TblCategoryID");

                    b.HasOne("VisionTake.Entities.TblSubCategory", "TblSubCategory")
                        .WithMany()
                        .HasForeignKey("TblSubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblCategory");

                    b.Navigation("TblSubCategory");
                });

            modelBuilder.Entity("VisionTake.Entities.EventPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblEvent", "TblEvent")
                        .WithMany()
                        .HasForeignKey("TblEventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblEvent");

                    b.Navigation("TblPicture");
                });

            modelBuilder.Entity("VisionTake.Entities.NewsPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblNews", "TblNews")
                        .WithMany()
                        .HasForeignKey("TblNewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblNews");

                    b.Navigation("TblPicture");
                });

            modelBuilder.Entity("VisionTake.Entities.PartnerPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblPartner", "TblPartner")
                        .WithMany()
                        .HasForeignKey("TblPartnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblPartner");

                    b.Navigation("TblPicture");
                });

            modelBuilder.Entity("VisionTake.Entities.ProductPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblProduct", "TblProduct")
                        .WithMany()
                        .HasForeignKey("TblProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblPicture");

                    b.Navigation("TblProduct");
                });

            modelBuilder.Entity("VisionTake.Entities.SliderPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblSlider", "TblSlider")
                        .WithMany()
                        .HasForeignKey("TblSliderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblPicture");

                    b.Navigation("TblSlider");
                });

            modelBuilder.Entity("VisionTake.Entities.SubCategoryPicture", b =>
                {
                    b.HasOne("VisionTake.Entities.TblPicture", "TblPicture")
                        .WithMany()
                        .HasForeignKey("TblPictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblSubCategory", "TblSubCategory")
                        .WithMany()
                        .HasForeignKey("TblSubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblPicture");

                    b.Navigation("TblSubCategory");
                });

            modelBuilder.Entity("VisionTake.Entities.TagNews", b =>
                {
                    b.HasOne("VisionTake.Entities.TblNews", "TblNews")
                        .WithMany()
                        .HasForeignKey("TblNewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblTag", "TblTag")
                        .WithMany()
                        .HasForeignKey("TblTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblNews");

                    b.Navigation("TblTag");
                });

            modelBuilder.Entity("VisionTake.Entities.TblProduct", b =>
                {
                    b.HasOne("VisionTake.Entities.TblCategory", "TblCategory")
                        .WithMany()
                        .HasForeignKey("TblCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisionTake.Entities.TblSubCategory", "TblSubCategory")
                        .WithMany()
                        .HasForeignKey("TblSubCategoryID");

                    b.Navigation("TblCategory");

                    b.Navigation("TblSubCategory");
                });

            modelBuilder.Entity("VisionTake.Entities.TblSubCategory", b =>
                {
                    b.HasOne("VisionTake.Entities.TblCategory", "TblCategory")
                        .WithMany()
                        .HasForeignKey("TblCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
