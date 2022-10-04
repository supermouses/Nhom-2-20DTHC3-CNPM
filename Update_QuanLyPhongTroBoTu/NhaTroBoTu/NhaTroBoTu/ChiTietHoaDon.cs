namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [StringLength(30)]
        public string MAHD { get; set; }

        [StringLength(30)]
        public string MAKH { get; set; }

        [Column(TypeName = "money")]
        public decimal? SODIENDAU { get; set; }

        [Column(TypeName = "money")]
        public decimal? SODIENCUOI { get; set; }

        [Column(TypeName = "money")]
        public decimal? SONUOCDAU { get; set; }

        [Column(TypeName = "money")]
        public decimal? SONUOCCUOI { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOTIEN { get; set; }
    }
}
