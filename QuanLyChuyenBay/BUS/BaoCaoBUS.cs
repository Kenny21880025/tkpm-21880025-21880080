using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class BaoCaoBUS
    {
        BaoCaoDAO bcDb = new BaoCaoDAO();
        public DataTable BaoCaoThang(string thang, string nam)
        {
            return bcDb.BaoCaoThang(thang, nam);
        }
        public DataTable BaoCaoNam(string nam)
        {
            return bcDb.BaoCaoNam(nam);
        }
        public int LuuBaoCaoNam(DoanhThuNam dtnam)
        {
            return bcDb.LuuBaoCaoNam(dtnam);
        }
        public int LuuBaoCaoThang(DoanhThuThang dtthang)
        {
            return bcDb.LuuBaoCaoThang(dtthang);
        }
        public DataTable TyLe(string thang, string nam)
        {
            return bcDb.TyLe(thang, nam);
        }
        
    }
}
