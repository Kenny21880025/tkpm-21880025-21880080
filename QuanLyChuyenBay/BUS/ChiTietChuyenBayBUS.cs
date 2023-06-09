using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class ChiTietChuyenBayBUS
    {
        ChiTietChuyenBayDAO cbDb = new ChiTietChuyenBayDAO();
        public DataTable LayDanhSach()
        {
            return cbDb.LayDanhSach();
        }
        public int ThemCTChuyenBay(ChiTietChuyenBay ctcb)
        {
            return cbDb.ThemCTChuyenBay(ctcb);
        }
        public DataTable LayTDChiTietChuyenBay()
        {
            return cbDb.LayTDChiTietChuyenBay();
        }
    }
}
