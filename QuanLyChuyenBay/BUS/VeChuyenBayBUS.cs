using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class VeChuyenBayBUS
    {
        VeChuyenBayDAO vcbDb = new VeChuyenBayDAO();
        public int ThemVeChuyenBay(VeChuyenBay ve)
        {
            return vcbDb.ThemVeChuyenBay(ve);
        }
        public DataTable LayDS()
        {
            return vcbDb.LayDanhSach();
        }
        public int XoaVe(string mv)
        {
            return vcbDb.XoaVe(mv);
        }
        public int CapNhatTrangThaiVe(string maHanhKhach, string trangThai)
        {
            return vcbDb.CapNhat(maHanhKhach, trangThai);
        }
    }
}
