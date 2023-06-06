using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class ChiTietChuyenBayDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "select * from ChuyenBay";
            return LayDuLieu(sql);
        }
        public int ThemCTChuyenBay(ChiTietChuyenBay ctcb)
        {
            string sql = string.Format("Insert into ChiTietChuyenBay(MaChuyenBay, SanBayTrungGian, ThoiGianDung, GhiChu) values('{0}', '{1}', '{2}', '{3}')", ctcb.MaChuyenBay, ctcb.SanBayTrungGian, ctcb.ThoiGianDung, ctcb.GhiChu);   
            return ThucThi(sql);
        }
        public DataTable LayTDChiTietChuyenBay(ChiTietChuyenBay ctcb)
        {
            DataTable ds;
            string sql = "SELECT SanBayTrungGian AS [Sân Bay Trung Gian], ThoiGianDung AS [Thời Gian Dừng], GhiChu AS [Ghi Chú] FROM ChiTietChuyenBay";
            ds = LayDuLieu(sql);
            return ds;
        }

    }
}
