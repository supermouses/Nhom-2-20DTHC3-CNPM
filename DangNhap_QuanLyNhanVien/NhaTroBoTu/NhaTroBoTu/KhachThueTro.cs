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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAKH { get; set; }

        [StringLength(30)]
        public string TENKH { get; set; }

        [StringLength(5)]
        public string GIOITINH { get; set; }

        [StringLength(100)]
        public string DC { get; set; }

        public int? SDT { get; set; }

        public int? CCCD { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? NAMSINH { get; set; }
    }
}
