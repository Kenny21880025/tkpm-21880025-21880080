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
        public DataTable LayDanhSach()
        {
            string sql = "select * from DonGia";
            return LayDuLieu(sql);
        }
        public double LayDonGia(string MaTuyenBay, string MaHangVe)
        {
            string sql = string.Format("SELECT DonGia FROM DonGia WHERE MaTuyenBay = '{0}' AND MaHangVe = '{1}'", MaTuyenBay, MaHangVe);
            return ThucThi(sql);
        }
    }
}