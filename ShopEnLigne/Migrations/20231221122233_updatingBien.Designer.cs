﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopEnLigne.Data;

#nullable disable

namespace ShopEnLigne.Migrations
{
    [DbContext(typeof(ShopEnLigneContext))]
    [Migration("20231221122233_updatingBien")]
    partial class updatingBien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopEnLigne.Models.Bien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Prix")
                        .HasColumnType("float");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.HasIndex("UserId");

                    b.ToTable("Bien");
                });

            modelBuilder.Entity("ShopEnLigne.Models.BlackList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BlackList");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("ShopEnLigne.Models.FavoriteList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteList");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Historique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BienId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BienId");

                    b.HasIndex("UserId");

                    b.ToTable("Historique");
                });

            modelBuilder.Entity("ShopEnLigne.Models.OffreSpeciale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BienId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TauxRemise")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BienId");

                    b.ToTable("OffreSpeciale");
                });

            modelBuilder.Entity("ShopEnLigne.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomSociete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Bien", b =>
                {
                    b.HasOne("ShopEnLigne.Models.Categorie", "Categorie")
                        .WithMany("Bien")
                        .HasForeignKey("CategorieId");

                    b.HasOne("ShopEnLigne.Models.User", "User")
                        .WithMany("Bien")
                        .HasForeignKey("UserId");

                    b.Navigation("Categorie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEnLigne.Models.BlackList", b =>
                {
                    b.HasOne("ShopEnLigne.Models.User", "User")
                        .WithMany("BlackLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEnLigne.Models.FavoriteList", b =>
                {
                    b.HasOne("ShopEnLigne.Models.User", "User")
                        .WithMany("FavoriteLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Historique", b =>
                {
                    b.HasOne("ShopEnLigne.Models.Bien", "Bien")
                        .WithMany("Historique")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEnLigne.Models.User", "User")
                        .WithMany("Historique")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEnLigne.Models.OffreSpeciale", b =>
                {
                    b.HasOne("ShopEnLigne.Models.Bien", "Bien")
                        .WithMany("OffreSpeciales")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Bien", b =>
                {
                    b.Navigation("Historique");

                    b.Navigation("OffreSpeciales");
                });

            modelBuilder.Entity("ShopEnLigne.Models.Categorie", b =>
                {
                    b.Navigation("Bien");
                });

            modelBuilder.Entity("ShopEnLigne.Models.User", b =>
                {
                    b.Navigation("Bien");

                    b.Navigation("BlackLists");

                    b.Navigation("FavoriteLists");

                    b.Navigation("Historique");
                });
#pragma warning restore 612, 618
        }
    }
}
