using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.BUS
{
    public class TuyenBayBUS
    {
        TuyenBayDAO tbDb = new TuyenBayDAO();
        public DataTable ChonTuyenBay(bool loai, string dk)
        {
            return tbDb.ChonTuyenBay(loai, dk);
        }
        public DataTable ChonTuyenBayTuTen(bool loai, string dk)
        {
            return tbDb.ChonTuyenBayTuTen(loai, dk);
        }
        public string LayMaTuyenBay(string sbdi, string sbden)
        {
            return tbDb.LayMaTuyenBay(sbdi, sbden);
        }
        
        public DataTable LayBangSBDenChoTuyenBay(string sbd)
        {
            return tbDb.LayBangSBDenChoTuyenBay(sbd);
        }
        public DataTable LayBangSBDenChoLichBay(string sbd)
        {
            return tbDb.LayBangSBDenChoLichBay(sbd);
        }
        public string LaySanBayDen(string sbdi)
        {
            return tbDb.LaySanBayDen(sbdi);
        }
        public int ThemTuyenBay(TuyenBay tb)
        {            
            return tbDb.ThemTuyenBay(tb);
        }
        public int XoaTuyenBay(string mtb)
        {
            
            return tbDb.XoaTuyenBay(mtb);
        }
        public int SuaTuyenBay(TuyenBay tb)
        {

            return tbDb.SuaTuyenBay(tb);
        }
        public DataTable LayDSTuyenBay()
        {
            return tbDb.LayDSTuyenBay();
        }
        public bool TuyenBayDaTonTai(TuyenBay tb)
        {
            return tbDb.TuyenBayDaTonTai(tb);
        }
    }    
}
