﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjeAppSube1;

#nullable disable

namespace ProjeAppSube1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjeAppSube1.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersID"));

                    b.Property<string>("DersAd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.Property<string>("DersKod")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.HasKey("DersID");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("ProjeAppSube1.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.HasKey("OgrenciID");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("ProjeAppSube1.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<string>("Ders")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciID", "DersID");

                    b.HasIndex("DersID");

                    b.ToTable("OgrenciDersler");
                });

            modelBuilder.Entity("ProjeAppSube1.Sinif", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"));

                    b.Property<string>("SinifAd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.Property<string>("SinifKontenjan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.HasKey("SinifId");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("ProjeAppSube1.Ogrenci", b =>
                {
                    b.HasOne("ProjeAppSube1.Sinif", "Sinif")
                        .WithMany("Ogrenci")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("ProjeAppSube1.OgrenciDers", b =>
                {
                    b.HasOne("ProjeAppSube1.Ders", "Dersler")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjeAppSube1.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dersler");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("ProjeAppSube1.Ders", b =>
                {
                    b.Navigation("OgrenciDers");
                });

            modelBuilder.Entity("ProjeAppSube1.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDers");
                });

            modelBuilder.Entity("ProjeAppSube1.Sinif", b =>
                {
                    b.Navigation("Ogrenci");
                });
#pragma warning restore 612, 618
        }
    }
}
