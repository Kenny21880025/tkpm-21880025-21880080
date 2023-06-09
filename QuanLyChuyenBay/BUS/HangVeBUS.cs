using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class HangVeBUS
    {
        HangVeDAO hvDb = new HangVeDAO();
        public DataTable LayDanhSach()
        {
            return hvDb.LayDanhSach();
        }
        public DataTable LayDSHangVe()
        {
            return hvDb.LayDSHangVe();
        }
        public string LayTenHangVe(string mhv)
        {
            return hvDb.LayTenHangVe(mhv);
        }
        public int ThemHangVe(HangVe hv)
        {
            return hvDb.ThemHangVe(hv);
        }
        public int SuaHangVe(HangVe hv, string mhv)
        {
            return hvDb.SuaHangVe(hv, mhv);
        }
        public int XoaHangVe(string mhv)
        {
            return hvDb.XoaHangVe(mhv);
        }
    }
}
