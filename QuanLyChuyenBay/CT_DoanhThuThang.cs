using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    public class CT_DoanhThuThang
    {
        public string MaCTDoanhThuThang {get;set; }
        public string MaDoanhThuThang { get; set; }
        public string MaChuyenBay { get; set; }
        public int SoVe { get; set; }
        public float TyLe { get; set; }
        public float DoanhThu { get; set; }
        //public byte[] timestamp { get; set; }

    }
}
