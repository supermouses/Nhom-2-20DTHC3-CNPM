namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongTro")]
    public partial class PhongTro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPT { get; set; }

        [StringLength(30)]
        public string TENPT { get; set; }

        [StringLength(15)]
        public string LP { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA { get; set; }

        public int? DT { get; set; }
    }
}
