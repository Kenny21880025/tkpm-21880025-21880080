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

namespace QuanLyChuyenBay.GUI
{
    public partial class MH_SuaChuyenBay : Form
    {
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        public string MaChuyenBay { get; set; }
        public MH_SuaChuyenBay()
        {
            InitializeComponent();
        }

        private void MH_SuaChuyenBay_Load(object sender, EventArgs e)
        {
            // Gán giá trị mã tuyến bay vào textbox
            txtMaChuyenBay.Text = MaChuyenBay;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dtpNgayGio.Text == "")
            {
                MessageBox.Show("Chưa chọn lại ngày giờ mới !!!");
                return;
            }
            txtMaChuyenBay.Text = MaChuyenBay;
            // Lấy giá trị đã chỉnh sửa
            DateTime NgayGio = dtpNgayGio.Value;
            var rs = cbBus.SuaChuyenBay(MaChuyenBay, NgayGio);
            if (rs > 0)
            {
                MessageBox.Show("Sửa chuyến bay thành công !!!");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
