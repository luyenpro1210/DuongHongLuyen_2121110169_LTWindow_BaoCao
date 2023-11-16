namespace BaoCao.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giay")]
    public partial class Giay
    {
        [Key]
        public int MaGiay { get; set; }

        [Required]
        [StringLength(200)]
        public string TenGiay { get; set; }

        public int KichCo { get; set; }

        [Required]
        [StringLength(200)]
        public string Hang { get; set; }
    }
}
