using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class DangNhapBUS
    {
        DangNhapDAO dnDb = new DangNhapDAO();
        public DataTable LayDSNguoiDung(DangNhap dn)
        {
            return dnDb.LayDSNguoiDung(dn);
        }
        public int ThemNguoiDung(DangNhap dn)
        {
            return dnDb.ThemNguoiDung(dn);
        }
    }
}
