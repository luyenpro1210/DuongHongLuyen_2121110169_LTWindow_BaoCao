using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaoCao
{
    public partial class QLSachDBContext : DbContext
    {
        public QLSachDBContext()
            : base("name=QLSachDBContext")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Sach)
                .WithRequired(e => e.LoaiSach)
                .WillCascadeOnDelete(false);
        }
    }
}
