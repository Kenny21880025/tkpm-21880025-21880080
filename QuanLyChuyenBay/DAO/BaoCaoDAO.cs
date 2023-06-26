using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace QuanLyChuyenBay.DAO
{
    public class BaoCaoDAO : Db
    {
        public int LuuBaoCaoNam(DoanhThuNam dtnam)
        {
            string sql = string.Format($"INSERT INTO DoanhThuNam (MaDoanhThuNam, Nam, TongDoanhThuNam) VALUES ('{dtnam.MaDoanhThuNam}', {dtnam.Nam}, {dtnam.TongDoanhThuNam})");
            return ThucThi(sql);
        }
        public int LuuBaoCaoThang(DoanhThuThang dtthang)
        {
            string sql = string.Format($"INSERT INTO DoanhThuThang (MaDoanhThuThang,Thang, MaDoanhThuNam, SoChuyenBay, TyLe, TongDoanhThuThang) VALUES ('{dtthang.MaDoanhThuThang}', {dtthang.Thang}, '{dtthang.MaDoanhThuNam}', {dtthang.SoChuyenBay}, {dtthang.TyLe}, {dtthang.TongDoanhThuThang})");
            return ThucThi(sql);
        }
        public DataTable TyLe(string thang, string nam)
        {
            string sql = $"SELECT " +
             $"   SUM(TinhTrangVe.SoGheDat) AS TongSoGheDat, " +
             $"   SUM(TinhTrangVe.SoGheTrong) AS TongSoGheTrong " +
             $"FROM " +
             $"   ChuyenBay " +
             $"   JOIN TinhTrangVe ON ChuyenBay.MaChuyenBay = TinhTrangVe.MaChuyenBay " +
             $"WHERE " +
             $"   MONTH(ChuyenBay.NgayGio) = '{thang}' AND YEAR(ChuyenBay.NgayGio) = '{nam}'";
            return LayDuLieu(sql);
        }

        public DataTable BaoCaoThang(string thang, string nam)
        {
            string sql = string.Format("SELECT ChuyenBay.MaChuyenBay, ChuyenBay.NgayGio, COUNT(VeChuyenBay.MaVe) AS SoVe, " +
             "(COUNT(VeChuyenBay.MaVe) * 100.0 / NULLIF((SELECT SUM(TinhTrangVe.SoGheTrong + TinhTrangVe.SoGheDat) FROM TinhTrangVe WHERE TinhTrangVe.MaChuyenBay = ChuyenBay.MaChuyenBay), 0)) AS TyLe, " +
             "SUM(VeChuyenBay.GiaTien) AS DoanhThu " +
             "FROM ChuyenBay LEFT JOIN VeChuyenBay ON ChuyenBay.MaChuyenBay = VeChuyenBay.MaChuyenBay " +
             "WHERE MONTH(ChuyenBay.NgayGio) = {0} AND YEAR(ChuyenBay.NgayGio) = {1} " +
             "GROUP BY ChuyenBay.MaChuyenBay, ChuyenBay.NgayGio", thang, nam);
            return LayDuLieu(sql);
        }
        public DataTable BaoCaoNam(string nam)
        {            
            string sql = @"SELECT
    ROW_NUMBER() OVER (ORDER BY month) AS STT,
    month AS Tháng,
    COUNT(*) AS SốChuyếnBay,
    SUM(GiaTien) AS DoanhThu,
    CONCAT(ROUND(SUM(SoGheDat) * 100.0 / (SUM(SoGheDat) + SUM(SoGheTrong)), 2), '%') AS TỷLệ
FROM
    (
        SELECT
            MONTH(ChuyenBay.NgayGio) AS month,
            VeChuyenBay.MaChuyenBay,
            GiaTien,
            TinhTrangVe.SoGheDat,
            TinhTrangVe.SoGheTrong
        FROM
            VeChuyenBay
            JOIN ChuyenBay ON VeChuyenBay.MaChuyenBay = ChuyenBay.MaChuyenBay
            JOIN TinhTrangVe ON VeChuyenBay.MaChuyenBay = TinhTrangVe.MaChuyenBay
    ) AS subquery
GROUP BY
    month
ORDER BY
    month";
            return LayDuLieu(sql);
        }
    }
}
