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
    public partial class MH_ThemHangVe : Form
    {
        HangVeBUS hvBus = new HangVeBUS();
        HangVe hv = new HangVe();
        public MH_ThemHangVe()
        {
            InitializeComponent();
        }
        private void btn_LuuHangVe_Click(object sender, EventArgs e)
        {
            hv.MaHangVe = txtMaHangVe.Text;
            hv.TenHangVe = txtTenHangVe.Text;
            int rs = hvBus.ThemHangVe(hv);
            if (rs > 0)
            {
                // Hiển thị thông báo thành công
                MessageBox.Show("Lưu hạng vé thành công!");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txtMaHangVe.Text = "";
            txtTenHangVe.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaHangVe_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTenHangVe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
