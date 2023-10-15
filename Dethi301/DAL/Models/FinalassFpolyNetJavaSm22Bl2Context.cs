using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class FinalassFpolyNetJavaSm22Bl2Context : DbContext
{
    public FinalassFpolyNetJavaSm22Bl2Context()
    {
    }

    public FinalassFpolyNetJavaSm22Bl2Context(DbContextOptions<FinalassFpolyNetJavaSm22Bl2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<LoaiXm> LoaiXms { get; set; }

    public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TuanNC15\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Persist Security Info=True;User ID=sa;Password=sa;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ban__3214EC07CEDD2284");

            entity.ToTable("Ban");

            entity.HasIndex(e => e.Ma, "UQ__Ban__3214CC9E50720653").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdMqh).HasColumnName("IdMQH");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoThich).HasMaxLength(30);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdMqhNavigation).WithMany(p => p.Bans)
                .HasForeignKey(d => d.IdMqh)
                .HasConstraintName("FK1_MQH");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChucVu__3214EC077A797903");

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.Ma, "UQ__ChucVu__3214CC9E7099E015").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiSP__3214EC079761FC8A");

            entity.ToTable("LoaiSP");

            entity.HasIndex(e => e.Ma, "UQ__LoaiSP__3214CC9E73E0039A").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiXm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiXM__3214EC074A9D65B5");

            entity.ToTable("LoaiXM");

            entity.HasIndex(e => e.Ma, "UQ__LoaiXM__3214CC9EB97517C3").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<MoiQuanHe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MoiQuanH__3214EC074943C355");

            entity.ToTable("MoiQuanHe");

            entity.HasIndex(e => e.Ma, "UQ__MoiQuanH__3214CC9E6062AD23").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07960A08A7");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Ma, "UQ__NhanVien__3214CC9EB0540135").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.Ho).HasMaxLength(30);
            entity.Property(e => e.IdCv).HasColumnName("IdCV");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenDem).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCv)
                .HasConstraintName("FK1_NV");
        });

        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NXB__3214EC0779284A1E");

            entity.ToTable("NXB");

            entity.HasIndex(e => e.Ma, "UQ__NXB__3214CC9EEEF5A6F9").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sach__3214EC071DB3722A");

            entity.ToTable("Sach");

            entity.HasIndex(e => e.Ma, "UQ__Sach__3214CC9E4462CAE5").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DonGia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdNxb).HasColumnName("IdNXB");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayXuatBan).HasColumnType("date");
            entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdNxbNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.IdNxb)
                .HasConstraintName("FK1_NXB");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC075F3DF528");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Ma, "UQ__SanPham__3214CC9E6A0D9368").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLoaiSp).HasColumnName("IdLoaiSP");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLoaiSpNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdLoaiSp)
                .HasConstraintName("FK1_LSP");
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XeMay__3214EC07317F61DD");

            entity.ToTable("XeMay");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.GiaNhap)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLxm).HasColumnName("IdLXM");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLxmNavigation).WithMany(p => p.XeMays)
                .HasForeignKey(d => d.IdLxm)
                .HasConstraintName("FK1_LXM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
