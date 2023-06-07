using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class HangVeDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "select * from HangVe";
            return LayDuLieu(sql);
        }
        public DataTable LayDSHangVe()
        {
            string sql = "SELECT MaHangVe as [Mã Hạng Vé], TenHangVe as [Tên Hạng Vé] FROM HangVe";
            return LayDuLieu(sql);            
        }
        public DataTable LayTenHangVe(string mhv)
        {
            string sql = string.Format("select TenHangVe from HangVe where MaHangVe = '{0}'", mhv);
            return LayDuLieu(sql);
        }
        public int ThemHangVe(HangVe hv)
        {
            string sql = string.Format("insert into HangVe(MaHangVe, TenHangVe) values('{0}', '{1}')", hv.MaHangVe, hv.TenHangVe);
            return ThucThi(sql);
        }
        public int SuaHangVe(HangVe hv, string mhv)
        {
            string sql = string.Format("Update HangVe Set TenHangVe = '{0}' where MaHangVe = '{1}'", hv.TenHangVe, mhv);
            return ThucThi(sql);
        }
        public int XoaHangVe(string mhv)
        {
            string sql = string.Format("Delete from HangVe  where MaHangVe = '{0}'", mhv);
            return ThucThi(sql);
        }
    }
}
