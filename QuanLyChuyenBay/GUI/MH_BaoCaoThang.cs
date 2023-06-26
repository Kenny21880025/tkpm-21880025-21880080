using QuanLyChuyenBay.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class MH_BaoCaoThang : Form
    {
        DataTable bc = new DataTable();
        BaoCaoBUS bcBus = new BaoCaoBUS();        
        public MH_BaoCaoThang()
        {
            InitializeComponent();
        }

        private void MH_BaoCaoThang_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }
            cbThang.Text = DateTime.Now.Month.ToString();
            int j;
            for (j = 1990; j <= DateTime.Now.Year; j++)
            {
                cbNam.Items.Add(j);
            }
            cbNam.Text = DateTime.Now.Year.ToString();

        }
        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ combobox
            string thang = cbThang.Text;
            string nam = cbNam.Text;
            bc = bcBus.BaoCaoThang(thang, nam);
            grvThang.DataSource = bc;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Lưu báo cáo xuống cơ sở dữ liệu?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Thực thi hàm bcBus.LuuBaoCaoThang() khi người dùng nhấn OK
                double tongDoanhThu = 0;
                int soChuyenBay = 0;
                double tongTyLe = 0;
                foreach (DataRow row in bc.Rows)
                {
                    double doanhThu = row["DoanhThu"] != DBNull.Value ? Convert.ToDouble(row["DoanhThu"]) : 0.0;

                    tongDoanhThu += doanhThu;
                    // Đếm số chuyến bay từ mỗi dòng của bảng
                    soChuyenBay++;

                }
                DoanhThuThang dtthang = new DoanhThuThang();
                DataTable TyLe = bcBus.TyLe(thang, nam);

                // Lấy tổng SoGheDat và tổng SoGheTrong từ bảng TyLe
                double tongSoGheDat = Convert.ToDouble(TyLe.Rows[0]["TongSoGheDat"]);
                double tongSoGheTrong = Convert.ToDouble(TyLe.Rows[0]["TongSoGheTrong"]);

                // Tính tỷ lệ
                double tyLe = tongSoGheDat / (tongSoGheDat + tongSoGheTrong);
                dtthang.MaDoanhThuThang = "DT" + thang;
                dtthang.Thang = int.Parse(thang);
                dtthang.MaDoanhThuNam = "DT" + nam;
                dtthang.SoChuyenBay = soChuyenBay;
                dtthang.TyLe = tyLe;
                dtthang.TongDoanhThuThang = tongDoanhThu;
                var rs = bcBus.LuuBaoCaoThang(dtthang);
                if (rs > 0)
                {
                    MessageBox.Show("Lưu báo cáo thành công !!!");
                }
            }
        }     
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
