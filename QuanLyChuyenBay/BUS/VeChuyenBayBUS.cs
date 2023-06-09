using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class VeChuyenBayBUS
    {
        VeChuyenBayDAO vcbDb = new VeChuyenBayDAO();
        public int ThemVeChuyenBay(VeChuyenBay ve)
        {
            return vcbDb.ThemVeChuyenBay(ve);
        }
    }
}
