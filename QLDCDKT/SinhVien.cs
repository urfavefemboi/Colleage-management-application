namespace QLDCDKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(50)]
        public string MaSV { get; set; }

        [StringLength(50)]
        public string TenSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLop { get; set; }
    }
}
