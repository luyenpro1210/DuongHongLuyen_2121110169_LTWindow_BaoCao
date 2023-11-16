namespace BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiGiay")]
    public partial class LoaiGiay
    {
        [Key]
        public int MaLoai { get; set; }

        [Required]
        [StringLength(200)]
        public string TenGiay { get; set; }

        public int KichCo { get; set; }

        [Required]
        [StringLength(200)]
        public string Loai { get; set; }
    }
}
