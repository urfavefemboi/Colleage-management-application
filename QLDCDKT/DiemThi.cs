namespace QLDCDKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemThi")]
    public partial class DiemThi
    {
        [Key]
        [StringLength(50)]
        public string MaBaiThi { get; set; }

        [Column("DiemThi")]
        public double? DiemThi1 { get; set; }

        public double? DiemTBTP { get; set; }

        public double? TongDiem { get; set; }

        [StringLength(50)]
        public string XepLoai { get; set; }
    }
}
