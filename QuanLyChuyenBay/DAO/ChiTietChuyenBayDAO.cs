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
            // Kiểm tra xem MaChuyenBay có tồn tại trong bảng ChuyenBay hay không
            //string checkSql = string.Format("SELECT COUNT(*) FROM ChuyenBay WHERE MaChuyenBay = '{0}'", ctcb.MaChuyenBay);
            //int count = (int)ThucThi(checkSql);
            //if (count == 0)
            //{
            //    // MaChuyenBay không tồn tại trong bảng ChuyenBay, trả về -1 hoặc thông báo lỗi
            //    return -1; // hoặc throw new Exception("MaChuyenBay không tồn tại trong bảng ChuyenBay");
            //}

            string sql = string.Format("INSERT INTO ChiTietChuyenBay(MaChuyenBay, SanBayTrungGian, ThoiGianDung, GhiChu) VALUES ('{0}', '{1}', '{2}', '{3}')", ctcb.MaChuyenBay, ctcb.SanBayTrungGian, ctcb.ThoiGianDung, ctcb.GhiChu);
            int maChiTietChuyenBay = ThucThi(sql);
            return maChiTietChuyenBay;
        }

        public DataTable LayTDChiTietChuyenBay()
        {
            DataTable ds;
            string sql = "SELECT SanBayTrungGian AS [Sân Bay Trung Gian], ThoiGianDung AS [Thời Gian Dừng], GhiChu AS [Ghi Chú] FROM ChiTietChuyenBay";
            ds = LayDuLieu(sql);
            ds.Clear();
            return ds;
        }

    }
}

