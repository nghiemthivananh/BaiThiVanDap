﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NghiemThiVanAnh078.Data;

#nullable disable

namespace NghiemThiVanAnh078.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("NghiemThiVanAnh078.Models.NTVA078", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<double>("Diem")
                        .HasColumnType("REAL");

                    b.Property<int>("Tuoi")
                        .HasColumnType("INTEGER");

                    b.HasKey("Masinhvien");

                    b.ToTable("NTVA078");
                });
#pragma warning restore 612, 618
        }
    }
}
