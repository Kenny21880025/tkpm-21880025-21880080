using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class DonGiaBUS
    {
        DonGiaDAO dgDb = new DonGiaDAO();        
        public double LayDonGia(string MaTuyenBay, string MaHangVe)
        {
            return dgDb.LayDonGia(MaTuyenBay, MaHangVe);
        }
        public DataTable LayDanhSach(string MaTuyenBay, string MaHangVe)
        {
            return dgDb.LayDanhSach(MaTuyenBay, MaHangVe);
        }
    }
}
