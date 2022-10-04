using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WinFormsApp1
{
    public partial class ModelQuanLyNhanVien : DbContext
    {
        public ModelQuanLyNhanVien()
            : base("name=ModelQuanLyNhanVien")
        {
        }

        public virtual DbSet<Nhan_Vien> Nhan_Vien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
