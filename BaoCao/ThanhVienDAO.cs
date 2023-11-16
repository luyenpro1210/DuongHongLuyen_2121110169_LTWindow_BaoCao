using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    internal class ThanhVienDAO
    {
        QLSachDBContext db = null;
        public ThanhVienDAO()
        {
            db = new QLSachDBContext();
        }
        public ThanhVien getRow(string tendn, string matkhau)
        {
            return db.ThanhViens.Where(m => m.TenDN == tendn && m.MatKhau == matkhau).FirstOrDefault();
        }

        internal object getList()
        {
            throw new NotImplementedException();
        }
    }
}
