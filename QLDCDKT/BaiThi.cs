namespace QLDCDKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiThi")]
    public partial class BaiThi
    {
        [Key]
        [StringLength(50)]
        public string MaBaiThi { get; set; }

        [Required]
        [StringLength(50)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSV { get; set; }

        [Column("BaiThi")]
        [StringLength(100)]
        public string BaiThi1 { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        public virtual DiemThi DiemThi { get; set; }
    }
}
