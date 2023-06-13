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
        
        //public bool XacThucDangNhap(DangNhap dn)
        //{
        //    string sql = $"SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = '{dn.TenDangNhap}' AND MatKhau = '{dn.MatKhau}'";

        //    var tham_so = new Dictionary<string, object>()
        //{
        //    { "@TenDangNhap", dn.TenDangNhap },
        //    { "@MatKhau", dn.MatKhau }
        //};

        //    DataTable dataTable = LayDanhSachXacThuc(sql, tham_so);

        //    int count = dataTable.Rows.Count;

        //    return count > 0;
        //}

    }
}
