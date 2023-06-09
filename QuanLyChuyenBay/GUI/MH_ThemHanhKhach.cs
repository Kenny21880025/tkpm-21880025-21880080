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
    public partial class MH_ThemHanhKhach : Form
    {
        HanhKhachBUS hkBus = new HanhKhachBUS();
        HanhKhach hk = new HanhKhach();
        public MH_ThemHanhKhach()
        {
            InitializeComponent();
        }

        public void btn_ThemHanhKhach_Click(object sender, EventArgs e)
        {
            if (txtMaHanhKhach.Text == "")
            {
                MessageBox.Show("Hành khách chưa có mã");
                return;
            }
            hk.MaHanhKhach = txtMaHanhKhach.Text;
            hk.TenHanhKhach = txtTenHanhKhach.Text;
            hk.CMND = txtID.Text;
            hk.DienThoai = txtDienThoai.Text;
            hkBus.ThemHanhKhach(hk);
            hkBus = null;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtMaHanhKhach_LostFocus(object sender, EventArgs e)
        {
            hk = null;
        }
    }
}
