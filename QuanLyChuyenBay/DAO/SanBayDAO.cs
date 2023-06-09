using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class SanBayDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "select * from SanBay";
            return LayDuLieu(sql);
        }
        public DataTable LayDSSanBay()
        {
            string sql = "SELECT MaSanBay as [Mã Sân Bay], TenSanBay as [Tên Sân Bay] FROM SanBay";
            return LayDuLieu(sql);            
        }
        public DataTable LayTDSanBay()
        {
            DataTable tdsb = LayDSSanBay();
            tdsb.Clear();
            return tdsb;
        }
        public string LayTenSanBay(string msb)
        {
            string sql = string.Format("select TenHangVe from HangVe where MaHangVe = '{0}'", msb);
            string tsb = LayTen(sql);
            return tsb;
        }
        public int ThemSanBay(SanBay sb)
        {
            string sql = string.Format("insert into SanBay(MaSanBay, TenSanBay) values('{0}', '{1}')", sb.MaSanBay, sb.TenSanBay);
            return ThucThi(sql);
        }
        public int SuaSanBay(SanBay sb, string msb)
        {
            string sql = string.Format("Update SanBay Set TenSanBay = '{0}' where MaSanBay = '{1}'", sb.TenSanBay, msb);
            return ThucThi(sql);
        }
        public int XoaSanBay(string msb)
        {
            string sql = string.Format("Delete from SanBay  where MaSanBay = '{0}'", msb);
            return ThucThi(sql);
        }
    }
}
