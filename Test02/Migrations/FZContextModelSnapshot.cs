﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Test02.Migrations
{
    [DbContext(typeof(FZContext))]
    partial class FZContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test02.Models.Auto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BesitzerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Betrag")
                        .HasColumnType("float");

                    b.Property<int>("JahrHerstellung")
                        .HasColumnType("int");

                    b.Property<string>("Laufleistung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preis")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TypKraftstoff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zustand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BesitzerId");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("Test02.Models.Besitzer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geburtsdatum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Besitzer");
                });

            modelBuilder.Entity("Test02.Models.Auto", b =>
                {
                    b.HasOne("Test02.Models.Besitzer", null)
                        .WithMany("Autos")
                        .HasForeignKey("BesitzerId");
                });

            modelBuilder.Entity("Test02.Models.Besitzer", b =>
                {
                    b.Navigation("Autos");
                });
#pragma warning restore 612, 618
        }
    }
}
