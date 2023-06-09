using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class ThamSoDAO : Db
    {
        public DataTable LayQD1()
        {
            string sql = "select ThoiGianBayToiThieu,SoSanBayTrungGianToiDa,ThoiGianDungToiThieu,ThoiGianDungToiDa from Thamso";
            return LayDuLieu(sql);
        }        
        public int SuaQD1(QD1 qd)
        {
            string sql = string.Format("Update SanBay Set ThoiGianBayToiThieu = '{0}' SoSanBayTrungGianToiDa = '{1}' ThoiGianDungToiThieu '{2}' hoiGianDungToiDa '{3}'", qd.ThoiGianBayToiThieu, qd.SoSanByTrungGianToiDa, qd.ThoiGianDungToiThieu, qd.ThoiGianDungToiDa);
            return ThucThi(sql);
        }
        public DataTable LayQD2()
        {
            string sql = "select * from HangVe";
            return LayDuLieu(sql);
        }
        public int SuaQD2(QD2 qd)
        {
            string sql = string.Format("Update HangVe Set MaHangVe = '{0}'", qd.SLHangVe);
            return ThucThi(sql);
        }
        public int SuaQD3(QD3 qd)
        {
            string sql = string.Format("Update HangVe Set MaHangVe = '{0}'", qd.TimeCancel);
            return ThucThi(sql);
        }
        public DataTable LayBangDonGia()
        {
            string sql = "select sb1.TenSanBay,sb2.TenSanBay,hv.TenHangVe,dg.DonGia from SanBay sb1, SanBay sb2, HangVe hv1, HangVe hv2, DonGia dg, TuyenBay tb where sb1.MaSanBay=tb.SanBayDen and sb2.MaSanBay=tb.SanBayDi and dg.MaHangVe=hv.MaHangVe and dg.MaTuyenBay=tb.MaTuyenBay";
            return LayDuLieu(sql);
        }
    }
}