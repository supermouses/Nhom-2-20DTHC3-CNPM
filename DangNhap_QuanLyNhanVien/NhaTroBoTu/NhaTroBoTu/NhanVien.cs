namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MANV { get; set; }

        [StringLength(30)]
        public string TENNV { get; set; }

        public int? SDTNV { get; set; }

        [StringLength(50)]
        public string DCNV { get; set; }

        public DateTime? YEARNV { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }
    }
}
