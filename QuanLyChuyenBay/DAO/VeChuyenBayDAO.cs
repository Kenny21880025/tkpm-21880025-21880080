using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class VeChuyenBayDAO : Db
    {
        public int ThemVeChuyenBay(VeChuyenBay ve)
        {
            string sql = string.Format($"Insert into VeChuyenBay(MaChuyenBay,MaHangVe,MaHanhKhach,GiaTien) values('{ve.MaChuyenBay}', '{ve.MaHangVe}','{ve.MaHanhKhach}', {ve.GiaTien}");
            return ThucThi(sql);
        }
    }
}
