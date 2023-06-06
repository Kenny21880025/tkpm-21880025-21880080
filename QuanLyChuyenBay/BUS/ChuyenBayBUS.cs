using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class ChuyenBayBUS
    {
        ChuyenBayDAO cbDb = new ChuyenBayDAO();
        public DataTable LayDanhSach()
        {
            return cbDb.LayDanhSach();
        }
        public int ThemChuyenBay(ChuyenBay cb)
        {
            if (string.IsNullOrEmpty(cb.MaTuyenBay)) return -1;
            if (string.IsNullOrEmpty(cb.MaTuyenBay)) return -2;
            return cbDb.ThemChuyenBay(cb);
        }

        public DataTable LayMaCBSauNgay(DateTime NgayGio)
        {
            return cbDb.LayMaCBSauNgay(NgayGio);
        }

        public DataTable LayDSChuyenBayTheoMa(string ma)
        {
            return cbDb.LayDSChuyenBayTheoMa(ma);
        }

        public DataTable LayTDTraCuu(bool loai)
        {
            return cbDb.LayTDTraCuu(loai);
        }
        public DataTable TimChuyenBay(string SanBayDi, string SanBayDen, DateTime TuNgay, DateTime DenNgay)
        {
            return cbDb.TimChuyenBay(SanBayDi, SanBayDen, TuNgay, DenNgay);
        }
        public bool KiemTraChuyenBay(string MaChuyenBay)
        {
            return cbDb.KiemTraChuyenBay(MaChuyenBay);
        }
    }
    
}
