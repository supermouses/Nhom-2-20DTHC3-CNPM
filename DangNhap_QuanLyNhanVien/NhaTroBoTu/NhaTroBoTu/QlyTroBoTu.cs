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

        public virtual DbSet<KhachThueTro> KhachThueTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachThueTro>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachThueTro>()
                .Property(e => e.CCCD)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
