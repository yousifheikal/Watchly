﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Watchly.Data;

#nullable disable

namespace Watchly.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241213035115_Initial-Create-Movie-Category-Relationship")]
    partial class InitialCreateMovieCategoryRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Watchly.Entites.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Watchly.Entites.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<short>("Duration")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<string>("Language")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasDefaultValue("English");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("ReleaseDate")
                        .HasPrecision(3)
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("MovieId");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("Watchly.Entites.MovieCategory", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MovieCategories", (string)null);
                });

            modelBuilder.Entity("Watchly.Entites.MovieCategory", b =>
                {
                    b.HasOne("Watchly.Entites.Category", "Categories")
                        .WithMany("MovieCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchly.Entites.Movie", "Movie")
                        .WithMany("MovieCategories")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Watchly.Entites.Category", b =>
                {
                    b.Navigation("MovieCategories");
                });

            modelBuilder.Entity("Watchly.Entites.Movie", b =>
                {
                    b.Navigation("MovieCategories");
                });
#pragma warning restore 612, 618
        }
    }
}