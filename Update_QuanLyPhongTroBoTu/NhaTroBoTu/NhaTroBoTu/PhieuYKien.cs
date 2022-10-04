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
        [StringLength(30)]
        public string MAPYK { get; set; }

        [StringLength(30)]
        public string MAKH { get; set; }

        [StringLength(50)]
        public string GOPY { get; set; }
    }
}
