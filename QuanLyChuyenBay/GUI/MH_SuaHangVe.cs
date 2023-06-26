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
    public partial class MH_SuaHangVe : Form
    {
        HangVeBUS hvBus = new HangVeBUS();
        public string MaHangVe { get; set; }
        public MH_SuaHangVe()
        {
            InitializeComponent();
        }

        private void MH_SuaHangVe_Load(object sender, EventArgs e)
        {
            // Gán giá trị mã tuyến bay vào textbox
            txtMaHangVe.Text = MaHangVe;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenHangVe.Text == "")
            {
                MessageBox.Show("Chưa nhập tên hạng vé mới !!!");
                return;
            }
            // Lấy giá trị đã chỉnh sửa
            string TenHangVe = txtTenHangVe.Text;
            string MaHangVe = txtMaHangVe.Text;
            var rs = hvBus.SuaHangVe(MaHangVe, TenHangVe);
            if (rs > 0)
            {
                MessageBox.Show("Sửa hạng vé thành công !!!");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
