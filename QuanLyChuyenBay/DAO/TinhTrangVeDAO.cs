using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class TinhTrangVeDAO : Db
    {
        public int ThemTinhTrangVe(string MaChuyenBay, int SoGheTrong)
        {
            string sql = string.Format("insert into SanBay(MaSanBay, TenSanBay) values('{0}', '{1}')", MaChuyenBay, SoGheTrong);
            return ThucThi(sql);
        }
        public int CapNhatTinhTrangVe(string mcb, bool loai)
        {
            string sql = string.Format($"select SoGheTrong from TinhTrangVe where MaChuyenBay = '{mcb}'");
            DataTable ds = LayDuLieu(sql);
            int SoGheTrong, SoGheDat;
            SoGheTrong = Convert.ToInt32(ds.Rows[0][1]) - 1;
            if (loai) // cập nhật khi có người mua vé
            {
                sql = string.Format($"update TinhTrangVe set SoGheTrong='{SoGheTrong}' where MaChuyenBay='{mcb}'");
                return ThucThi(sql);
            }
            else
            {
                SoGheDat = 0; // giả sử số ghế đã đặt là 0, ta có thể thay đổi tùy theo logic cá nhân
                sql = string.Format($"update TinhTrangVe set SoGheTrong='{SoGheTrong}', SoGheDat='{SoGheDat}' where MaChuyenBay='{mcb}'");
                return ThucThi(sql);
            }
        }
        public string LayTinhTrangVe(string MaChuyenBay)
        {
            string tt;
            int SoGheTrong;
            string sql = string.Format($"select SoGheTrong from TinhTrangVe where MaChuyenBay= '{MaChuyenBay}'");
            SoGheTrong = LaySo(sql);
            if (SoGheTrong > 0)
            {
                tt = "Còn chỗ";
            }
            else
            {
                tt = "Đã hết chỗ";
            }
            return tt;
        }
    }
}
