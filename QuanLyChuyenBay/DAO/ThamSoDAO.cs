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
            string sql = string.Format("UPDATE ThamSo SET ThoiGianBayToiThieu = '{0}', SoSanBayTrungGianToiDa = '{1}', ThoiGianDungToiThieu = '{2}', ThoiGianDungToiDa = '{3}'", qd.ThoiGianBayToiThieu, qd.SoSanBayTrungGianToiDa, qd.ThoiGianDungToiThieu, qd.ThoiGianDungToiDa);

            return ThucThi(sql);
        }
        public DataTable LayQD2()
        {
            string sql = "select * from Thamso";
            return LayDuLieu(sql);
        }
        public int SuaQD2(QD2 qd)
        {
            string sql = string.Format("Update HangVe Set MaHangVe = '{0}'", qd.SLHangVe);
            return ThucThi(sql);
        }
        public DataTable LayQD3()
        {
            string sql = "select TGChamNhatDatVe,TGChamNhatHuyDatVe from Thamso";
            return LayDuLieu(sql);
        }
        public int SuaQD3(QD3 qd)
        {
            string sql = string.Format("Update ThamSo Set TGChamNhatDatVe = '{0}', TGChamNhatHuyDatVe = '{1}'", qd.TimeOrder, qd.TimeCancel);
            return ThucThi(sql);
        }
        public DataTable LayBangDonGia()
        {
            string sql = "select * from HangVe";
            return LayDuLieu(sql);
        }
    }
}