using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class ChuyenBayDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "select MaChuyenBay as [Mã Chuyến Bay], MaTuyenBay as [Mã Tuyến Bay], NgayGio as [Ngày Giờ], ThoiGianBay as [Thời Gian Bay], SoLuongGheHang1 as [Số Lượng Ghế Hạng 1], SoLuongGheHang2 as [Số Lượng Ghế Hạng 2] from ChuyenBay";

            return LayDuLieu(sql);
        }
        public int ThemChuyenBay(ChuyenBay cb)
        {
            string sql = string.Format("Insert into ChuyenBay(MaChuyenBay,MaTuyenBay,NgayGio,ThoiGianBay,SoLuongGheHang1,SoLuongGheHang2) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", cb.MaChuyenBay, cb.MaTuyenBay, cb.NgayGio, cb.ThoiGianBay, cb.SoLuongGheHang1, cb.SoLuongGheHang2);
            return ThucThi(sql);
        }
        public int XoaChuyenBay(string mtb)
        {
            string sql = string.Format("Delete from ChuyenBay  where MaChuyenBay = '{0}'", mtb);
            return ThucThi(sql);
        }
        public int SuaChuyenBay(string ma, DateTime date)
        {
            string sql = string.Format("Update ChuyenBay Set NgayGio = '{0}' where MaChuyenBay = '{1}'",date, ma);
            return ThucThi(sql);
        }
        public DataTable LayMaCBSauNgay(DateTime NgayGio)
        {
            DataTable ds;
            string sql = "select MaChuyenBay from ChuyenBay";
            //where NgayGio>='" + NgayGio + "'";
            ds = LayDuLieu(sql);
            return ds;
        }
        public DataTable LayDSChuyenBayTheoMa(string ma)
        {
            DataTable ds;
            string sql = string.Format($"select sb1.TenSanBay,sb2.TenSanBay,cb.NgayGio,tb.MaTuyenBay from ChuyenBay cb,TuyenBay tb,SanBay sb1,SanBay sb2 where sb1.MaSanBay=tb.SanBayDi and sb2.MaSanBay=tb.SanBayDen and cb.MaTuyenBay=tb.MaTuyenBay and MaChuyenBay='{ma}'");
            ds = LayDuLieu(sql);
            return ds;
        }
        public DateTime LayNgayBay(string maChuyenBay)
        {
            DateTime ngayKhoiHanh = DateTime.MinValue;
            string sql = $"SELECT NgayKhoiHanh FROM ChuyenBay WHERE MaChuyenBay = '{maChuyenBay}'";
            LayNgay(sql);
            return ngayKhoiHanh;
        }
        public DataTable LayTDTraCuu(bool loai)
        {
            DataTable ds;
            string sql = "select sb1.TenSanBay as [Sân Bay Đi],sb2.TenSanBay as [Sân Bay Đến],cb.NgayGio as [Khởi Hành],cb.ThoiGianBay as [Thời Gian],ttv.SoGheTrong as [Số Ghế Trống],ttv.SoGheDat as [Số Ghế Đặt] from ChuyenBay cb, SanBay sb1, SanBay sb2, TinhTrangVe ttv, TuyenBay tb where tb.MaTuyenBay=cb.MaTuyenBay and tb.SanBayDi=sb1.MaSanBay and tb.SanBayDen=sb2.MaSanBay and ttv.MaChuyenBay=cb.MaChuyenBay";
            ds = LayDuLieu(sql);
            if (loai == true)
            {
                ds.Clear();
            }
            return ds;
        }
        public DataTable TimChuyenBay(string SanBayDi, string SanBayDen, DateTime TuNgay, DateTime DenNgay)
        {
            string sql = $"SELECT sb1.TenSanBay AS [Sân Bay Đi], sb2.TenSanBay AS [Sân Bay Đến], cb.NgayGio AS [Khởi Hành], cb.ThoiGianBay AS [Thời Gian], ttv.SoGheTrong AS [Số Ghế Trống], ttv.SoGheDat AS [Số Ghế Đặt] " +
             $"FROM SanBay sb1, SanBay sb2, ChuyenBay cb, TinhTrangVe ttv, TuyenBay tb " +
             $"WHERE tb.SanBayDi = sb1.MaSanBay AND tb.SanBayDen = sb2.MaSanBay AND tb.MaTuyenBay = cb.MaTuyenBay AND sb1.MaSanBay = '{SanBayDi}' AND sb2.MaSanBay = '{SanBayDen}' AND cb.MaChuyenBay = ttv.MaChuyenBay AND (cb.NgayGio BETWEEN '{TuNgay}' AND '{DenNgay}') " +
             $"ORDER BY cb.NgayGio ASC";            
            return LayDuLieu(sql);
        }
        public bool KiemTraChuyenBay(string MaChuyenBay)
        {
            string sql = "select count(*) from ChuyenBay where MaChuyenBay='" + MaChuyenBay + "'";
            int kq = LaySo(sql);
            if (kq == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
