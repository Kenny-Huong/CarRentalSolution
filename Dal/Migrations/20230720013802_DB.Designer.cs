﻿// <auto-generated />
using System;
using Dal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dal.Migrations
{
    [DbContext(typeof(CarRentalDBContext))]
    [Migration("20230720013802_DB")]
    partial class DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dal.Modal.BaoDuong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ChiPhi")
                        .HasColumnType("Decimal");

                    b.Property<Guid>("IdXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDangKiem")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("DateTime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdXe");

                    b.ToTable("Bảo dưỡng", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.BaoHiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiBaoHiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ThoiHan")
                        .HasColumnType("DateTime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bảo Hiểm", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Chức Vụ", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.DangKiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDangKiem")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("DateTime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdXe");

                    b.ToTable("Đăng kiểm", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.HangXe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hãng Xe", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("DECIMAL");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("DateTime");

                    b.Property<decimal>("PhuPhi")
                        .HasColumnType("DECIMAL");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("DECIMAL");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdXe");

                    b.ToTable("Hoá đơn chi tiết", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.HoaDonThueXe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("DateTime");

                    b.Property<int>("SoHopDong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("Hoá đơn thuê xe", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("Bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Khách hàng", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.LoaiXe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiNguyenLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoaiSoXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NhienLieuTieuThu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SoGhe")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHangXe");

                    b.ToTable("Loại xe", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Màu sắc", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.NguoiThan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("Người thân", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("Bit");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("DateTime");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.ToTable("Nhân viên", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.TaiKhoan", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.HasIndex("IdNhanVien")
                        .IsUnique();

                    b.ToTable("Tài khoản", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.Xe", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BienSo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("DECIMAL");

                    b.Property<Guid>("IdLoaiXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoaiXeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoKhung")
                        .HasColumnType("int");

                    b.Property<int>("SoMay")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("LoaiXeId");

                    b.ToTable("Xe", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.XeBaoHiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ChiPhi")
                        .HasColumnType("DECIMAL");

                    b.Property<Guid>("IdHangBaoHiem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("DateTime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHangBaoHiem");

                    b.HasIndex("IdXe");

                    b.ToTable("Xe bảo hiểm", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.BaoDuong", b =>
                {
                    b.HasOne("Dal.Modal.Xe", "Xe")
                        .WithMany("baoDuongs")
                        .HasForeignKey("IdXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("Dal.Modal.DangKiem", b =>
                {
                    b.HasOne("Dal.Modal.Xe", "Xe")
                        .WithMany("DangKiem")
                        .HasForeignKey("IdXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("Dal.Modal.HoaDonChiTiet", b =>
                {
                    b.HasOne("Dal.Modal.HoaDonThueXe", "HoaDonThueXe")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.Xe", "Xe")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonThueXe");

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("Dal.Modal.HoaDonThueXe", b =>
                {
                    b.HasOne("Dal.Modal.KhachHang", "KhachHang")
                        .WithMany("HoaDonThueXe")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.NhanVien", "NhanVien")
                        .WithMany("HoaDonThueXes")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Dal.Modal.LoaiXe", b =>
                {
                    b.HasOne("Dal.Modal.HangXe", "HangXe")
                        .WithMany("LoaiXe")
                        .HasForeignKey("IdHangXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangXe");
                });

            modelBuilder.Entity("Dal.Modal.NguoiThan", b =>
                {
                    b.HasOne("Dal.Modal.KhachHang", "KhachHangs")
                        .WithMany("NguoiThans")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("Dal.Modal.NhanVien", b =>
                {
                    b.HasOne("Dal.Modal.ChucVu", "ChucVu")
                        .WithMany("NhanVien")
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("Dal.Modal.TaiKhoan", b =>
                {
                    b.HasOne("Dal.Modal.NhanVien", "NhanVien")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("Dal.Modal.TaiKhoan", "IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Dal.Modal.Xe", b =>
                {
                    b.HasOne("Dal.Modal.MauSac", "MauSac")
                        .WithMany("Xes")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.LoaiXe", "LoaiXe")
                        .WithMany("Xe")
                        .HasForeignKey("LoaiXeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiXe");

                    b.Navigation("MauSac");
                });

            modelBuilder.Entity("Dal.Modal.XeBaoHiem", b =>
                {
                    b.HasOne("Dal.Modal.BaoHiem", "BaoHiem")
                        .WithMany("xeBaoHiems")
                        .HasForeignKey("IdHangBaoHiem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.Xe", "Xe")
                        .WithMany("xeBaoHiems")
                        .HasForeignKey("IdXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaoHiem");

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("Dal.Modal.BaoHiem", b =>
                {
                    b.Navigation("xeBaoHiems");
                });

            modelBuilder.Entity("Dal.Modal.ChucVu", b =>
                {
                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Dal.Modal.HangXe", b =>
                {
                    b.Navigation("LoaiXe");
                });

            modelBuilder.Entity("Dal.Modal.HoaDonThueXe", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("Dal.Modal.KhachHang", b =>
                {
                    b.Navigation("HoaDonThueXe");

                    b.Navigation("NguoiThans");
                });

            modelBuilder.Entity("Dal.Modal.LoaiXe", b =>
                {
                    b.Navigation("Xe");
                });

            modelBuilder.Entity("Dal.Modal.MauSac", b =>
                {
                    b.Navigation("Xes");
                });

            modelBuilder.Entity("Dal.Modal.NhanVien", b =>
                {
                    b.Navigation("HoaDonThueXes");

                    b.Navigation("TaiKhoan")
                        .IsRequired();
                });

            modelBuilder.Entity("Dal.Modal.Xe", b =>
                {
                    b.Navigation("DangKiem");

                    b.Navigation("HoaDonChiTiets");

                    b.Navigation("baoDuongs");

                    b.Navigation("xeBaoHiems");
                });
#pragma warning restore 612, 618
        }
    }
}