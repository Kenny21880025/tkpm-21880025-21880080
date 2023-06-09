using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class PhieuDatChoBUS
    {
        PhieuDatChoDAO pdcDb = new PhieuDatChoDAO();
        public int ThemPhieuDatCho(PhieuDatCho pdc)
        {
            return pdcDb.ThemPhieuDatCho(pdc);
        }
    }
}
