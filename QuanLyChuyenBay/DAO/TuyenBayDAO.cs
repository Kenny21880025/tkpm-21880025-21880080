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

        public DataTable LayCacSBDenKoThoa(string sbd)
        {
            string sql = "select * from SanBay";
            //string sql = string.Format("select sb.MaSanBay from SanBay sb where sb.MaSanBay <> '{0}' and sb.MaSanBay not in (select tb.SanBayDen from TuyenBay tb where tb.SanBayDi='{0}')", sbd);
            DataTable ds = LayDuLieu(sql);
            DataRow[] rows = ds.Select(string.Format("MaSanBay = '{0}'", sbd));
            if (rows.Length > 0)
            {
                ds.Rows.Remove(rows[0]);
            }

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
