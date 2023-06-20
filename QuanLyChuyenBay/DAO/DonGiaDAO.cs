using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class DonGiaDAO : Db
    {
        public DataTable LayDanhSach(string MaTuyenBay, string MaHangVe)
        {
            string sql = $"select * from DonGia WHERE MaTuyenBay = '{MaTuyenBay}' AND MaHangVe = '{MaHangVe}'";
            return LayDuLieu(sql);
        }
        public double LayDonGia(string MaTuyenBay, string MaHangVe)
        {
            string sql = string.Format($"SELECT Gia FROM DonGia WHERE MaTuyenBay = '{MaTuyenBay}' AND MaHangVe = '{MaHangVe}'");
            return ThucThi(sql);
        }
    }
}