using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class SanBayBUS
    {
        SanBayDAO sbDb = new SanBayDAO();
        public DataTable LayDanhSach()
        {
            return sbDb.LayDanhSach();
        }
        public DataTable LayDSSanBay()
        {
            return sbDb.LayDSSanBay();
        }
        public DataTable LayTDSanBay()
        {
            return sbDb.LayTDSanBay();
        }
        public string LayTenSanBay(string sb)
        {
            return sbDb.LayTenSanBay(sb);
        }
        //public int ThemSanBay(SanBay sb)
        //{
        //    return ThemSanBay(sb);
        //}
        //public int SuaSanBay(SanBay sb, string msb)
        //{
        //    return SuaSanBay(sb, msb);
        //}
        //public int XoaSanBay(string msb)
        //{
        //    return XoaSanBay(msb);
        //}
    }
}
