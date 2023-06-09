using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class TuyenBayBUS
    {
        TuyenBayDAO tbDb = new TuyenBayDAO();
        public DataTable ChonTuyenBay(bool loai, string dk)
        {
            return tbDb.ChonTuyenBay(loai, dk);
        }
        public DataTable ChonTuyenBayTuTen(bool loai, string dk)
        {
            return tbDb.ChonTuyenBayTuTen(loai, dk);
        }
        public string LayMaTuyenBay(string sbdi, string sbden)
        {
            return tbDb.LayMaTuyenBay(sbdi, sbden);
        }

        public DataTable LayCacSBDenKoThoa(string sbd)
        {
            return tbDb.LayCacSBDenKoThoa(sbd);
        }
        public int ThemTuyenBay(string MaTuyenBay, string SanBayDi, string SanBayDen)
        {
            if (string.IsNullOrEmpty(MaTuyenBay)) return -1;
            if (string.IsNullOrEmpty(MaTuyenBay)) return -2;
            return tbDb.ThemTuyenBay(MaTuyenBay, SanBayDi, SanBayDen);
        }
        public DataTable LayDSTuyenBay()
        {
            return tbDb.LayDSTuyenBay();
        }
    }    
}
