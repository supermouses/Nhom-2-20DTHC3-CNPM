using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NhaTroBoTu
{
    public partial class QlyTroBoTu : DbContext
    {
        public QlyTroBoTu()
            : base("name=QlyTroBoTu")
        {
        }

        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachThueTro> KhachThueTroes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBaoTri> PhieuBaoTris { get; set; }
        public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }
        public virtual DbSet<PhieuYKien> PhieuYKiens { get; set; }
        public virtual DbSet<PhongTro> PhongTroes { get; set; }
        public virtual DbSet<TienNghi> TienNghis { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .Property(e => e.PHIDV)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<PhieuBaoTri>()
                .Property(e => e.MAPBT)
                .IsFixedLength();

            modelBuilder.Entity<PhieuBaoTri>()
                .Property(e => e.PHIBT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuPhat>()
                .Property(e => e.MAPP)
                .IsFixedLength();

            modelBuilder.Entity<PhieuPhat>()
                .Property(e => e.PHIPHAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MAHD)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MAKH)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SODIENDAU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SODIENCUOI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SONUOCDAU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SONUOCCUOI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SOTIEN)
                .HasPrecision(19, 4);
        }
    }
}
