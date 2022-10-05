namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuBaoTri")]
    public partial class PhieuBaoTri
    {
        [Key]
        [StringLength(30)]
        public string MAPBT { get; set; }

        [StringLength(30)]
        public string MAKH { get; set; }

        [Column(TypeName = "money")]
        public decimal? PHIBT { get; set; }

        public DateTime? NGAYBT { get; set; }
    }
}
