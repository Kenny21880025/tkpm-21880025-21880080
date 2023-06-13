using QuanLyChuyenBay.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyChuyenBay.GUI
{
    public partial class MH_DangNhap : Form
    {
        public MH_DangNhap()
        {
            InitializeComponent();
        }
        DangNhapBUS dnBus = new DangNhapBUS();
        DangNhap dn = new DangNhap();
        public string TenDangNhap { get; private set; }
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
            dn.TenDangNhap = txtTenDangNhap.Text;
            dn.MatKhau = txtMatKhau.Text;
            DataTable dsND = dnBus.LayDSNguoiDung(dn);
            if (dsND.Rows.Count > 0 && dsND.Rows[0][0].ToString() == "1")
            {
                // Lưu tên đăng nhập vào biến tạm
                TenDangNhap = txtTenDangNhap.Text;
                // Đăng nhập thành công, trả về kết quả DialogResult.OK
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng. Vui lòng nhập lại.");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
