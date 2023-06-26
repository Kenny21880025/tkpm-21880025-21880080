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
                MessageBox.Show("Hành khách chưa có mã !!!");
                return;
            }
            if (txtTenHanhKhach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên hành khách !!!");
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại hành khách !!!");
                return;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Chưa nhập số căn cước hành khách !!!");
                return;
            }
            hk.MaHanhKhach = txtMaHanhKhach.Text;
            hk.TenHanhKhach = txtTenHanhKhach.Text;
            hk.CMND = txtID.Text;
            hk.DienThoai = txtDienThoai.Text;
            hkBus.ThemHanhKhach(hk);
            hk = new HanhKhach();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtMaHanhKhach_LostFocus(object sender, EventArgs e)
        {
            hk = new HanhKhach();
        }
    }
}
