using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NhaTroBoTu
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QuanLyPTBT")
        {
        }

        public virtual DbSet<KhachThueTro> KhachThueTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
