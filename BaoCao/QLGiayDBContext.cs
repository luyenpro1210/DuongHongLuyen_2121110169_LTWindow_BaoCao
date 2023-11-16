using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaoCao
{
    public partial class QLGiayDBContext : DbContext
    {
        public QLGiayDBContext()
            : base("name=QLGiayDBContext")
        {
        }

        public virtual DbSet<Giay> Giayes { get; set; }
        public virtual DbSet<LoaiGiay> LoaiGiayes { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
