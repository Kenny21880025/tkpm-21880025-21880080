using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class PhieuDatChoBUS
    {
        PhieuDatChoDAO pdcDb = new PhieuDatChoDAO();
        public int ThemPhieuDatCho(PhieuDatCho pdc)
        {
            return pdcDb.ThemPhieuDatCho(pdc);
        }
        public DataTable LayDSPhieuDatCho()
        {
            return pdcDb.LayDSPhieuDatCho();
        }
        public int CapNhatTrangThaiPhieuDatCho(int phieuDatChoID,string trangThai)
        {
            return pdcDb.CapNhat(phieuDatChoID, trangThai);
        }
        public int KiemTraMaHanhKhachTrongPhieuDatCho(string maHanhKhach)
        {
            return pdcDb.KiemTra(maHanhKhach);
        }
        public int CapNhatPhieuSauKhiXuatVe(string maHanhKhach, string trangThai)
        {
            return pdcDb.CapNhatKhiXuatVe(maHanhKhach, trangThai);
        }
        public DataTable LayPhieuTheoMa(string maHanhKhach)
        {
            return pdcDb.LayPhieuTheoMa(maHanhKhach);
        }
    }
}
