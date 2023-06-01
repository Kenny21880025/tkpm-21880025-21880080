using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    public class ChiTietChuyenBay
    {
        public int MaChiTietChuyenBay { get; set; }
        public string MaChuyenBay { get; set; }
        public string SanBayTrungGian { get; set; }
        public int    ThoiGianDung { get; set; }
        public string GhiChu { get; set; }
    }    
}
