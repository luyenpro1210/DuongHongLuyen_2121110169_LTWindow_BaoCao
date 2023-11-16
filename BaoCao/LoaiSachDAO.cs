using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    internal class LoaiSachDAO
    {
        QLSachDBContext db = null;
        public LoaiSachDAO()
        {
            db = new QLSachDBContext();
        }

        public List<LoaiSach> getList()
        {
            return db.LoaiSaches.ToList();
        }
        public LoaiSach getRow(int maLoaiSach)
        {
            return db.LoaiSaches.Find(maLoaiSach);
        }
        public int getCount()
        {
            return db.LoaiSaches.Count();
        }
        public void Insert(LoaiSach LoaiSach)
        {
            db.LoaiSaches.Add(LoaiSach);
            db.SaveChanges();
        }
        public void Update(LoaiSach LoaiSach)
        {
            db.Entry(LoaiSach).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(LoaiSach LoaiSach)
        {
            db.LoaiSaches.Remove(LoaiSach);
            db.SaveChanges();
        }
        public void Delete(int maLoaiSach)
        {
            LoaiSach LoaiSach = db.LoaiSaches.Find(maLoaiSach);
            db.LoaiSaches.Remove(LoaiSach);
            db.SaveChanges();
        }

    }
}
