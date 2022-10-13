namespace NhaTroBoTu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TienNghi")]
    public partial class TienNghi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATN { get; set; }

        [StringLength(30)]
        public string TENTN { get; set; }

        [StringLength(15)]
        public string LOAITN { get; set; }
    }
}
