using System;
using System.Text;
using System.Windows.Forms;
using QuanLyChuyenBay.GUI;

namespace QuanLyChuyenBay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult ket_qua = DialogResult.Cancel;

            // Khởi tạo và hiển thị form đăng nhập
            MH_DangNhap mhdn = new MH_DangNhap();
            ket_qua = mhdn.ShowDialog();

            // Kiểm tra kết quả đăng nhập
            if (ket_qua == DialogResult.OK)
            {
                // Lấy tên đăng nhập từ MH_DangNhap
                string tenDangNhap = mhdn.TenDangNhap;
                Application.Run(new Form1 { TenDangNhap = tenDangNhap });
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!!!");
            }    
        }
    }
}
