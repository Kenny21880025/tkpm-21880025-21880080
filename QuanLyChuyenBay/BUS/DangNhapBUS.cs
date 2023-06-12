using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class DangNhapBUS
    {
        DangNhapDAO dnDb = new DangNhapDAO();
        public bool XacThucDangNhap(DangNhap dn)
        {
            return dnDb.XacThucDangNhap(dn);
        }
    }
}
