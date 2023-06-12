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

            DialogResult ket_qua = DialogResult.Cancel; // Khởi tạo giá trị mặc định cho biến ket_qua

            // Hiển thị form đăng nhập trước khi hiển thị form chính
            MH_DangNhap mhdn = new MH_DangNhap();
            ket_qua = mhdn.ShowDialog();

            // Kiểm tra kết quả đăng nhập
            if (ket_qua == DialogResult.OK)
            {
                // Người dùng đăng nhập thành công, hiển thị form chính
                Application.Run(new Form1());
            }
            else
            {
                // Người dùng không đăng nhập thành công, hiển thị thông báo và không khởi chạy ứng dụng
                MessageBox.Show("Đăng nhập không thành công.");
            }
        }
    }
}