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
        public DataTable LayThamSo()
        {
            return sbDb.LayThamSo();
        }
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
        public int ThemSanBay(SanBay sb)
        {
            if (string.IsNullOrEmpty(sb.MaSanBay)) return -1;
            if (string.IsNullOrEmpty(sb.TenSanBay)) return -2;
            return sbDb.ThemSanBay(sb);
        }
        public int SuaSanBay(SanBay sb)
        {
            return sbDb.SuaSanBay(sb);
        }
        public int XoaSanBay(string msb)
        {
            return sbDb.XoaSanBay(msb);
        }
    }
}
