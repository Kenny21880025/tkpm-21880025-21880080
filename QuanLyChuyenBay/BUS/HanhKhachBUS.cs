using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class HanhKhachBUS
    {
        HanhKhachDAO hkDb = new HanhKhachDAO();
        public DataTable LayDanhSach()
        {
            return hkDb.LayDanhSach();
        }
        public int ThemHanhKhach(HanhKhach hk)
        {
            return hkDb.ThemHanhKhach(hk);
        }
        public int XoaHanhKhach(string hk)
        {
            return hkDb.XoaHanhKhach(hk);
        }
        public int SuaHanhKhach(string mhk, string dt, string id)
        {
            return hkDb.SuaHanhKhach(mhk, dt, id);
        }
        public DataTable LayHanhKhachTuMa(string mhk)
        {
            return hkDb.LayHanhKhachTuMa(mhk);
        }
    }
}
