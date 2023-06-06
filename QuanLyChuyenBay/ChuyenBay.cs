using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    public class ChuyenBay : Db
    {
        public string MaChuyenBay { get; set; }
        public string MaTuyenBay { get; set; }
        public DateTime NgayGio { get; set; }
        public int  ThoiGianBay { get; set; }
        public int SoLuongGheHang1 { get; set; }
        public int SoLuongGheHang2 { get; set; }
    }   
}
