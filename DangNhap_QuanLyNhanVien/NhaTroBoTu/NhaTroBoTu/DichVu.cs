namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MANV { get; set; }

        [StringLength(30)]
        public string TENDV { get; set; }

        [StringLength(15)]
        public string LDV { get; set; }

        [Column(TypeName = "money")]
        public decimal? PHIDV { get; set; }
    }
}
