namespace WinFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhan_Vien
    {
        [Key]
        [Column("Mã NV")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mã_NV { get; set; }

        [Column("Tên NV")]
        [Required]
        [StringLength(30)]
        public string Tên_NV { get; set; }

        public int SĐT { get; set; }

        [Column("Địa Chỉ")]
        [Required]
        [StringLength(100)]
        public string Địa_Chỉ { get; set; }

        [Column("Ngày Sinh", TypeName = "date")]
        public DateTime Ngày_Sinh { get; set; }

        [Column("Giới Tính")]
        [Required]
        [StringLength(5)]
        public string Giới_Tính { get; set; }

        [Column("Chức Vụ")]
        [Required]
        [StringLength(15)]
        public string Chức_Vụ { get; set; }
    }
}
