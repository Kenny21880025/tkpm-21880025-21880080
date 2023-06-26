using QuanLyChuyenBay.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class MH_BaoCaoNam : Form
    {
        BaoCaoBUS bcBus = new BaoCaoBUS();
        DataTable bc = new DataTable();
        DoanhThuNam dtnam = new DoanhThuNam();
        public MH_BaoCaoNam()
        {
            InitializeComponent();
        }

        private void MH_BaoCaoNam_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbNam.Items.Add(i);
            }
            cbNam.Text = DateTime.Now.Year.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            string nam = cbNam.Text;
            bc = bcBus.BaoCaoNam(nam);
            grvNam.Columns.Add("Nam", "Năm: " + nam);
            grvNam.DataSource = bc;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Lưu báo cáo xuống cơ sở dữ liệu?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Thực thi hàm bcBus.LuuBaoCaoNam() khi người dùng nhấn OK
                
                double tongDoanhThu = 0;
                foreach (DataRow row in bc.Rows)
                {
                    double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                    tongDoanhThu += doanhThu;
                }
                dtnam.MaDoanhThuNam = "DT" + nam;
                dtnam.Nam = int.Parse(nam);
                dtnam.TongDoanhThuNam = tongDoanhThu;
                var rs = bcBus.LuuBaoCaoNam(dtnam);
                if (rs > 0)
                {
                    MessageBox.Show("Lưu báo cáo thành công !!!");
                }
            }
        }
    }
}
