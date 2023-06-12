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
    public partial class MH_DangNhap : Form
    {
        DangNhapBUS dnBus = new DangNhapBUS();
        DangNhap dn = new DangNhap();        
        public MH_DangNhap()
        {
            InitializeComponent();
        }
        private void MH_DangNhap_Load(object sender, EventArgs e)
        {
            dn.TenDangNhap = txtTenDangNhap.Text;
            dn.MatKhau = txtMatKhau.Text;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                return;
            }

            bool isOK = dnBus.XacThucDangNhap(dn);

            if (isOK)
            {
                // Đăng nhập thành công, đóng màn hình đăng nhập và trả về kết quả OK
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng. Vui lòng nhập lại.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
