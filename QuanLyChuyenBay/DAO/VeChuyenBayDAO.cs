using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class VeChuyenBayDAO : Db
    {
        public int ThemVeChuyenBay(VeChuyenBay ve)
        {
            string sql = string.Format("INSERT INTO VeChuyenBay (MaChuyenBay, MaHanhKhach, MaHangVe, GiaTien, NgayBan, TrangThai) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                ve.MaChuyenBay, ve.MaHanhKhach, ve.MaHangVe, ve.GiaTien, ve.NgayBan, ve.TrangThai);
            return ThucThi(sql);
        }
        public DataTable LayDanhSach()
        {
            string sql = "select * from VeChuyenBay";
            return LayDuLieu(sql);
        }
        public int XoaVe(string mv)
        {
            string sql = string.Format("Delete from VeChuyenBay  where MaVe = '{0}'", mv);
            return ThucThi(sql);
        }
        public int CapNhat(string maHanhKhach, string trangThai)
        {
            string sql = $"UPDATE VeChuyenBay SET TrangThai = '{trangThai}' WHERE MaHanhKhach = {maHanhKhach}";
            return ThucThi(sql);
        }
    }
}
