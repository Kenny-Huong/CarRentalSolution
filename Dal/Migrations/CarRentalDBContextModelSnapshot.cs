﻿// <auto-generated />
using System;
using Dal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dal.Migrations
{
    [DbContext(typeof(CarRentalDBContext))]
    partial class CarRentalDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("SoCongToBaoDuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdXe");

                    b.ToTable("Bao_Duong", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.BaoHiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiBaoHiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bao_Hiem", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.ChiPhiPhatSinh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("DECIMAL");

                    b.Property<Guid>("IdHDCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLPP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdHDCT");

                    b.HasIndex("IdLPP");

                    b.ToTable("Chi Phi Phat Sinh", (string)null);
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

                    b.ToTable("Chuc_Vu", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.DangKiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ChiPhi")
                        .HasColumnType("DECIMAL");

                    b.Property<Guid>("IdXe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDangKiem")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("IdXe");

                    b.ToTable("Đang_kiem", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.GiayToTheChap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiGiayTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Giay To The Chap", (string)null);
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

                    b.ToTable("Hang_Xe", (string)null);
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

                    b.Property<decimal>("TienCoc")
                        .HasColumnType("DECIMAL");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("DECIMAL");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdXe");

                    b.ToTable("Hoa_đon_chi_tiet", (string)null);
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

                    b.ToTable("Hoa_don_thue_xe", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("Bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("DateTime");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Khach_hang", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.LoaiPhuPhi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiPhuPhi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("LoaiPhuPhi", (string)null);
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

                    b.ToTable("Loai_xe", (string)null);
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

                    b.ToTable("Mau_sac", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.NguoiThan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

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

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("Nguoi_than", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
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

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.ToTable("Nhan_vien", (string)null);
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

                    b.ToTable("Tai_khoan", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.TaiSanTheChap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiTaiSan")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tai San The Chap", (string)null);
                });

            modelBuilder.Entity("Dal.Modal.TheChap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GiaTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IdGiayTo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHDCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTS")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdGiayTo");

                    b.HasIndex("IdHDCT");

                    b.HasIndex("IdTS");

                    b.ToTable("The Chap", (string)null);
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

                    b.Property<int>("SoCongTo")
                        .HasColumnType("int");

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

                    b.ToTable("Xe_bao_hiem", (string)null);
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

            modelBuilder.Entity("Dal.Modal.ChiPhiPhatSinh", b =>
                {
                    b.HasOne("Dal.Modal.HoaDonChiTiet", "HoaDonChiTiet")
                        .WithMany("chiPhiPhatSinhs")
                        .HasForeignKey("IdHDCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.LoaiPhuPhi", "LoaiPhuPhi")
                        .WithMany("chiPhiPhatSinhs")
                        .HasForeignKey("IdLPP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonChiTiet");

                    b.Navigation("LoaiPhuPhi");
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

            modelBuilder.Entity("Dal.Modal.TheChap", b =>
                {
                    b.HasOne("Dal.Modal.GiayToTheChap", "GiayToTheChap")
                        .WithMany("TheChap")
                        .HasForeignKey("IdGiayTo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.HoaDonChiTiet", "HoaDonChiTiet")
                        .WithMany("theChaps")
                        .HasForeignKey("IdHDCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Modal.TaiSanTheChap", "TaiSanTheChap")
                        .WithMany("TheChap")
                        .HasForeignKey("IdTS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiayToTheChap");

                    b.Navigation("HoaDonChiTiet");

                    b.Navigation("TaiSanTheChap");
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

            modelBuilder.Entity("Dal.Modal.GiayToTheChap", b =>
                {
                    b.Navigation("TheChap");
                });

            modelBuilder.Entity("Dal.Modal.HangXe", b =>
                {
                    b.Navigation("LoaiXe");
                });

            modelBuilder.Entity("Dal.Modal.HoaDonChiTiet", b =>
                {
                    b.Navigation("chiPhiPhatSinhs");

                    b.Navigation("theChaps");
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

            modelBuilder.Entity("Dal.Modal.LoaiPhuPhi", b =>
                {
                    b.Navigation("chiPhiPhatSinhs");
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

            modelBuilder.Entity("Dal.Modal.TaiSanTheChap", b =>
                {
                    b.Navigation("TheChap");
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
