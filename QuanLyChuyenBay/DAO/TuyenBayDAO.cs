using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class TuyenBayDAO : Db
    {
        public DataTable ChonTuyenBay(bool loai, string dk)
        {
            DataTable ds;
            string sql = "select SanBayDi,SanBayDen from TuyenBay";
            if (!string.IsNullOrEmpty(dk))
            {
                if (loai)
                {
                    sql += " where SanBayDi=''";
                }
                else
                {
                    sql += " where SanBayDen=''";
                }
                sql += dk + "''";
            }
            ds = LayDuLieu(sql);
            return ds;
        }
        public DataTable ChonTuyenBayTuTen(bool loai, string dk)
        {
            DataTable ds;
            string tableName = (loai ? "tb.SanBayDen" : "tb.SanBayDi");
            string condition = (loai ? "sb2.MaSanBay=tb.SanBayDi" : "sb2.MaSanBay=tb.SanBayDen");            
            string sql = string.Format("select sb1.TenSanBay from SanBay sb1 where sb1.MaSanBay in (select {0} from SanBay sb2,TuyenBay tb where {1} and TenSanBay='{2}')", tableName, condition, dk);
            // Lấy dữ liệu từ cơ sở dữ liệu
            ds = LayDuLieu(sql);

            return ds;
        }
        public string LayMaTuyenBay(string sbdi, string sbden)
        {
            string ma;
            string sql = string.Format("select MaTuyenBay from TuyenBay where SanBayDi='{0}' and SanBayDen='{1}'", sbdi, sbden);
            ma = LayTen(sql);
            return ma;
        }
        public string LaySanBayDen(string sbdi)
        {
            string ma;
            string sql = string.Format("select SanBayDen from TuyenBay where SanBayDi='{0}'", sbdi);
            ma = LayTen(sql);
            return ma;
        }

        public DataTable LayBangSBDenChoLichBay(string sbdi)
        {
            string sql = string.Format("select * from TuyenBay where SanBayDi='{0}'", sbdi);
            //string sql = string.Format("SELECT * FROM SanBay WHERE MaSanBay <> '{0}' AND MaSanBay NOT IN (SELECT SanBayDen FROM TuyenBay WHERE SanBayDi = '{0}')", sbd);
            DataTable ds = LayDuLieu(sql);
            return ds;
        }
        public DataTable LayBangSBDenChoTuyenBay(string sbdi)
        {
            //string sql = string.Format("select SanBayDen from TuyenBay where SanBayDi='{0}'", sbdi);
            string sql = string.Format("SELECT * FROM SanBay WHERE MaSanBay <> '{0}' AND MaSanBay NOT IN (SELECT SanBayDen FROM TuyenBay WHERE SanBayDi = '{0}')", sbdi);
            DataTable ds = LayDuLieu(sql);
            return ds;
        }
        public int ThemTuyenBay(TuyenBay tb)
        {
            string sql = string.Format("Insert into TuyenBay(MaTuyenBay,SanBayDi, SanBayDen) values ('{0}', '{1}', '{2}')", tb.MaTuyenBay, tb.SanBayDi, tb.SanBayDen);
            return ThucThi(sql);
        }

        public DataTable LayDSTuyenBay()
        {
            string sql = "select tb.MaTuyenBay as [Mã Tuyến Bay],sb1.TenSanBay as [Sân Bay Đi],sb2.TenSanBay as [Sân Bay Đến] from TuyenBay tb,SanBay sb1,SanBay sb2 where tb.SanBayDi=sb1.MaSanBay and tb.SanBayDen=sb2.MaSanBay";
            DataTable ds = LayDuLieu(sql);
            return ds;
        }
        public bool TuyenBayDaTonTai(TuyenBay tb)
        {
            string sql = string.Format("SELECT COUNT(*) FROM TuyenBay WHERE MaTuyenBay = '{0}'", tb.MaTuyenBay);
            object result = LayDuLieuScalar(sql);

            int count;
            if (result != null && int.TryParse(result.ToString(), out count))
            {
                return count > 0;
            }
            return false;
        }

    }
}
