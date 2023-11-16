using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaoCao.EF
{
    public partial class QuanLyBanGiayContext : DbContext
    {
        public QuanLyBanGiayContext()
            : base("name=QuanLyBanGiayContext")
        {
        }

        public virtual DbSet<Giay> Giay { get; set; }
        public virtual DbSet<LoaiGiay> LoaiGiay { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
