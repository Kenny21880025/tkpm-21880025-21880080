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
    public partial class MH_ThemNhanVien : Form
    {
        DangNhap tk = new DangNhap();
        DangNhapBUS dnBus = new DangNhapBUS();
        public MH_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Chưa nhập tên người dùng !!!");
                return;
            }
            if (txtPW.Text == "")
            {
                MessageBox.Show("Chưa nhập nhập mật khẩu");
                return;
            }
            tk.TenDangNhap = txtID.Text;
            tk.MatKhau = txtPW.Text;
            var rs = dnBus.ThemNguoiDung(tk);
            if (rs > 0)
            {
                MessageBox.Show("Thêm người dùng thành công");
            }
        }

        private void btn_XoaTrang_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPW.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
