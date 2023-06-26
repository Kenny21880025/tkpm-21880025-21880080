using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable LayDSPhieuDatCho()
        {
            string sql = "select * from PhieuDatCho";
            return LayDuLieu(sql);
        }
        public DataTable LayPhieuTheoMa(string ma)
        {
            string sql = $"select * from PhieuDatCho where MaHanhKhach = {ma}";
            return LayDuLieu(sql);
        }
        public int CapNhat(int maPhieuDatID, string trangThai)
        {
            string sql = $"UPDATE PhieuDatCho SET TrangThai = '{trangThai}' WHERE MaPhieuDat = {maPhieuDatID}";
            return ThucThi(sql);
        }
        public int KiemTra(string maHanhKhach)
        {
            string sql = $"SELECT COUNT(*) FROM PhieuDatCho WHERE MaHanhKhach = '{maHanhKhach}'";
            return ThucThi(sql);
        }
        public int CapNhatKhiXuatVe(string maHanhKhach,string trangThai)
        {
            string sql = $"UPDATE PhieuDatCho SET TrangThai = '{trangThai}' WHERE MaHanhKhach = '{maHanhKhach}'";
            return ThucThi(sql);
        }
        public PhieuDatCho LayPhieu(string maHanhKhach)
        {
            return null;
        }    
    }

}
