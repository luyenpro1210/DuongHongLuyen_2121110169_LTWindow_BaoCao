using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    internal class LoaiGiayDAO
    {
        QLGiayDBContext db = null;
        public LoaiGiayDAO()
        {
            db = new QLGiayDBContext();
        }

        public List<LoaiGiay> getList()
        {
            return db.LoaiGiayes.ToList();
        }
        public LoaiGiay getRow(int maLoaiGiay)
        {
            return db.LoaiGiayes.Find(maLoaiGiay);
        }
        public int getCount()
        {
            return db.LoaiGiayes.Count();
        }
        public void Insert(LoaiGiay LoaiGiay)
        {
            db.LoaiGiayes.Add(LoaiGiay);
            db.SaveChanges();
        }
        public void Update(LoaiGiay LoaiGiay)
        {
            db.Entry(LoaiGiay).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(LoaiGiay LoaiGiay)
        {
            db.LoaiGiayes.Remove(LoaiGiay);
            db.SaveChanges();
        }
        public void Delete(int maLoaiGiay)
        {
            LoaiGiay LoaiGiay = db.LoaiGiayes.Find(maLoaiGiay);
            db.LoaiGiayes.Remove(LoaiGiay);
            db.SaveChanges();
        }

    }
}
