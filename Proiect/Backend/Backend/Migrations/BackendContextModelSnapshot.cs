﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(BackendContext))]
    partial class BackendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.Cos_Cumparaturi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Cos", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Discounts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Cos_CumparaturiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount_Percent")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Promo_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cos_CumparaturiId")
                        .IsUnique()
                        .HasFilter("[Cos_CumparaturiId] IS NOT NULL");

                    b.ToTable("Discount", (string)null);
                });

            modelBuilder.Entity("Backend.Models.LoginModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Produse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Cos_CumparaturiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pret")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Cos_CumparaturiId");

                    b.ToTable("Produs", (string)null);
                });

            modelBuilder.Entity("Backend.Models.RegisterModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Register", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Stoc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Nr_Produse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stocul", (string)null);
                });

            modelBuilder.Entity("Backend.Models.StocProdus", b =>
                {
                    b.Property<Guid>("ProdusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StocId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProdusId", "StocId");

                    b.HasIndex("StocId");

                    b.ToTable("StocProduse", (string)null);
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balanta_Cont")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Cos_Cumparaturi", b =>
                {
                    b.HasOne("Backend.Models.User", "user")
                        .WithOne("Cos")
                        .HasForeignKey("Backend.Models.Cos_Cumparaturi", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Backend.Models.Discounts", b =>
                {
                    b.HasOne("Backend.Models.Cos_Cumparaturi", "Cos_Redus")
                        .WithOne("Discount")
                        .HasForeignKey("Backend.Models.Discounts", "Cos_CumparaturiId");

                    b.Navigation("Cos_Redus");
                });

            modelBuilder.Entity("Backend.Models.Produse", b =>
                {
                    b.HasOne("Backend.Models.Cos_Cumparaturi", "Cos")
                        .WithMany("Produse_Alese")
                        .HasForeignKey("Cos_CumparaturiId");

                    b.Navigation("Cos");
                });

            modelBuilder.Entity("Backend.Models.StocProdus", b =>
                {
                    b.HasOne("Backend.Models.Produse", "Produs")
                        .WithMany("StocProduse")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Stoc", "Stoc")
                        .WithMany("StocProduse")
                        .HasForeignKey("StocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produs");

                    b.Navigation("Stoc");
                });

            modelBuilder.Entity("Backend.Models.Cos_Cumparaturi", b =>
                {
                    b.Navigation("Discount");

                    b.Navigation("Produse_Alese");
                });

            modelBuilder.Entity("Backend.Models.Produse", b =>
                {
                    b.Navigation("StocProduse");
                });

            modelBuilder.Entity("Backend.Models.Stoc", b =>
                {
                    b.Navigation("StocProduse");
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Navigation("Cos")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
