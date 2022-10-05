namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuPhat")]
    public partial class PhieuPhat
    {
        [Key]
        [StringLength(30)]
        public string MAPP { get; set; }

        [StringLength(30)]
        public string MAKH { get; set; }

        public DateTime? NGAYPP { get; set; }

        [Column(TypeName = "money")]
        public decimal? PHIPHAT { get; set; }
    }
}
