using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class TinhTrangVeBUS
    {
        TinhTrangVeDAO ttvDb = new TinhTrangVeDAO();
        public int ThemTinhTrangVe(string MaChuyenBay, int SoGheTrong, int SoGheDat)
        {
            return ttvDb.ThemTinhTrangVe(MaChuyenBay, SoGheTrong, SoGheDat);
        }
        public int CapNhatTinhTrangVe(string mcb, bool loai)
        {
            return ttvDb.CapNhatTinhTrangVe(mcb, loai);
        }
        public string LayTinhTrangVe(string MaChuyenBay)
        {
            return ttvDb.LayTinhTrangVe(MaChuyenBay);
        }
    }
}
