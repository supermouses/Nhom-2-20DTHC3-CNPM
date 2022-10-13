namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuYKien")]
    public partial class PhieuYKien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPYK { get; set; }

        public int? MAKH { get; set; }

        [StringLength(50)]
        public string GOPY { get; set; }

        public virtual KhachThueTro KhachThueTro { get; set; }
    }
}
