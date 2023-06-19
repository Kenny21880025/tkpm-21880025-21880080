using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class HanhKhachDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "select * from HanhKhach";
            return LayDuLieu(sql);
        }
        public int ThemHanhKhach(HanhKhach hk)
        {
            string sql = string.Format("Insert into HanhKhach(MaHanhKhach,TenHanhKhach,CMND,DienThoai) values('{0}', '{1}', '{2}', '{3}')", hk.MaHanhKhach, hk.TenHanhKhach, hk.CMND, hk.DienThoai);
            return ThucThi(sql);
        }
        public int XoaHanhKhach(string hk)
        {
            string sql = string.Format("Delete from HanhKhach  where MaHanhKhach = '{0}'", hk);
            return ThucThi(sql);
        }
        public int SuaHanhKhach(string hk, string dt, string id)
        {
            string sql = string.Format("Update HanhKhach Set DienThoai = '{0}', CCCD = '{1}' where MaHanhKhach = '{2}'", hk, dt,id);
            return ThucThi(sql);
        }
        public DataTable LayHanhKhachTuMa(string mhk)
        {
            string sql = string.Format("select TenHanhKhach,CMND,DienThoai from HanhKhach where MaHanhKhach = '{0}'", mhk);
            return LayDuLieu(sql);
        }
    }
}
