using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class DangNhapDAO : Db
    {
        public DataTable LayDSNguoiDung(DangNhap dn)
        {
            string sql = $"SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = '{dn.TenDangNhap}' AND MatKhau = '{dn.MatKhau}'";

            return LayDuLieu(sql);
        }
        public int ThemNguoiDung(DangNhap dn)
        {
            string sql = string.Format($"INSERT INTO NguoiDung(TenDangNhap, MatKhau) Values('{0}', '{1}')", dn.TenDangNhap, dn.MatKhau);
            return ThucThi(sql);
        }
    }
}
