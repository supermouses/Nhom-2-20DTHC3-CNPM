namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachThueTro")]
    public partial class KhachThueTro
    {
        [Key]
        [StringLength(5)]
        public string MaKH { get; set; }

        [StringLength(30)]
        public string TenKH { get; set; }

        [StringLength(5)]
        public string GioiTinhKH { get; set; }

        [StringLength(100)]
        public string DiaChiKH { get; set; }

        public int? SDTKH { get; set; }

        [StringLength(15)]
        public string CCCD { get; set; }

        public DateTime? NgaySinhKH { get; set; }
    }
}
