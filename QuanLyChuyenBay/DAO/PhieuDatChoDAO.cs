using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class PhieuDatChoDAO : Db
    {
        public int ThemPhieuDatCho(PhieuDatCho pdc)
        {
            string sql = string.Format("INSERT INTO PhieuDatCho (MaChuyenBay, MaHanhKhach, MaHangVe, GiaTien, NgayDat) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                pdc.MaChuyenBay, pdc.MaHanhKhach, pdc.MaHangVe, pdc.GiaTien, pdc.NgayDat);

            int rowsAffected = ThucThi(sql); // Thêm phiếu đặt chỗ

            if (rowsAffected > 0)
            {
                sql = string.Format("UPDATE TinhTrangVe SET SoGheDat = SoGheDat + 1 WHERE MaChuyenBay = '{0}'", pdc.MaChuyenBay);
                return ThucThi(sql); // Cập nhật tình trạng vé
            }

            return 0;
        }
    }

}
