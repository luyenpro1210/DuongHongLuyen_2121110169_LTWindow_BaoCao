using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    internal class GiayDAO
    {
        QLGiayDBContext db = null;
        public GiayDAO()
        {
            db = new QLGiayDBContext();
        }

        public List<Giay> getList()
        {
            return db.Giayes.ToList();
        }
        public Giay getRow(int maGiay)
        {
            return db.Giayes.Find(maGiay);
        }
        public int getCount()
        {
            return db.Giayes.Count();
        }
        public void Insert(Giay Giay)
        {
            db.Giayes.Add(Giay);
            db.SaveChanges();
        }
        public void Update(Giay Giay)
        {
            db.Entry(Giay).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(Giay Giay)
        {
            db.Giayes.Remove(Giay);
            db.SaveChanges();
        }
        public void Delete(int maGiay)
        {
            Giay Sach = db.Giayes.Find(maGiay);
            db.Giayes.Remove(Sach);
            db.SaveChanges();
        }

    }
}
