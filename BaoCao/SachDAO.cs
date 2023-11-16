using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    internal class SachDAO
    {
        QLSachDBContext db = null;
        public SachDAO()
        {
            db = new QLSachDBContext();
        }

        public List<Sach> getList()
        {
            return db.Saches.ToList();
        }
        public Sach getRow(int maSach)
        {
            return db.Saches.Find(maSach);
        }
        public int getCount()
        {
            return db.Saches.Count();
        }
        public void Insert(Sach Sach)
        {
            db.Saches.Add(Sach);
            db.SaveChanges();
        }
        public void Update(Sach Sach)
        {
            db.Entry(Sach).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(Sach Sach)
        {
            db.Saches.Remove(Sach);
            db.SaveChanges();
        }
        public void Delete(int maSach)
        {
            Sach Sach = db.Saches.Find(maSach);
            db.Saches.Remove(Sach);
            db.SaveChanges();
        }

    }
}
