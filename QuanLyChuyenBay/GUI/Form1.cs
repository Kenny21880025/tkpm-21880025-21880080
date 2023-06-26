using System.Data;
using System.Windows.Forms;
using QuanLyChuyenBay.BUS;
using QuanLyChuyenBay.DAO;
using QuanLyChuyenBay.GUI;

namespace QuanLyChuyenBay
{
    public partial class Form1 : Form
    {
        ChuyenBayBUS cbDb = new ChuyenBayBUS();
        DangNhap dn = new DangNhap();
        PhieuDatChoBUS pdcBus = new PhieuDatChoBUS();
        VeChuyenBayBUS vcbBus = new VeChuyenBayBUS();
        public string TenDangNhap { get; set; }
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown; // Gắn sự kiện Shown
        }
        private void btn_NhanLich_Click(object sender, EventArgs e)
        {
            MH_NhanLich mhnl = new MH_NhanLich();
            mhnl.Show();
        }
        private void btn_LayDanhSachChuyenBay_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = cbDb.LayDanhSach();
            grvLichBay.DataSource = bang;
        }
        private void btn_BanVe_Click(object sender, EventArgs e)
        {
            MH_BanVe mhbv = new MH_BanVe();
            mhbv.Show();
        }
        private void btn_DatCho_Click(object sender, EventArgs e)
        {
            MH_DatCho mhdc = new MH_DatCho();
            mhdc.Show();
        }
        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            MH_TraCuu mhtc = new MH_TraCuu();
            mhtc.Show();
        }
        private void menuXinChao_Click(object sender, EventArgs e)
        {
            menuXinChao.Text = "Xin chào " + TenDangNhap;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            menuXinChao.Text = "Xin chào " + TenDangNhap;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void DT_Thang_Click(object sender, EventArgs e)
        {
            MH_BaoCaoThang mhbct = new MH_BaoCaoThang();
            mhbct.Show();
        }
        private void DT_Nam_Click(object sender, EventArgs e)
        {
            MH_BaoCaoNam mhbcn = new MH_BaoCaoNam();
            mhbcn.Show();
        }
        private void QD1_Click(object sender, EventArgs e)
        {
            MH_QD1 mhqd1 = new MH_QD1();
            mhqd1.Show();
        }
        private void QD2_Click(object sender, EventArgs e)
        {
            MH_QD2 mhqd2 = new MH_QD2();
            mhqd2.Show();
        }
        private void QD3_Click(object sender, EventArgs e)
        {
            MH_QD3 mhqd3 = new MH_QD3();
            mhqd3.Show();
        }
        private void DS_TuyenBay_Click(object sender, EventArgs e)
        {
            MH_DSTuyenBay mhdstb = new MH_DSTuyenBay();
            mhdstb.Show();
        }
        private void DS_SanBay_Click(object sender, EventArgs e)
        {
            MH_DSSanBay mhdssb = new MH_DSSanBay();
            mhdssb.Show();
        }
        private void DS_HangVe_Click(object sender, EventArgs e)
        {
            MH_DSHangVe mhdshv = new MH_DSHangVe();
            mhdshv.Show();
        }
        private void DS_KhachHang_Click(object sender, EventArgs e)
        {
            MH_DSKhachHang mhdskh = new MH_DSKhachHang();
            mhdskh.Show();
        }
        private void DS_ChuyenBay_Click(object sender, EventArgs e)
        {
            MH_DSChuyenBay mhdscb = new MH_DSChuyenBay();
            mhdscb.Show();
        }
        private void HuyVe_Click(object sender, EventArgs e)
        {
            MH_HuyVe mh = new MH_HuyVe();
            mh.Show();
        }
        private void btn_HuyPhieuDat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy tất cả các phiếu đặt vé?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lấy ngày hiện tại
                DateTime ngayHienTai = DateTime.Now.Date;

                // Lấy danh sách các phiếu đặt chỗ từ cơ sở dữ liệu
                DataTable dsPhieu = pdcBus.LayDSPhieuDatCho();

                // Lặp qua từng dòng trong DataTable và cập nhật trạng thái "Đã hủy"
                foreach (DataRow row in dsPhieu.Rows)
                {
                    // Lấy thông tin từ các cột tương ứng trong DataTable
                    int phieuDatChoID = Convert.ToInt32(row["MaPhieuDat"]);
                    string maChuyenBay = Convert.ToString(row["MaChuyenBay"]);

                    // Lấy thông tin ngày khởi hành từ bảng ChuyenBay
                    DateTime ngayKhoiHanh = cbDb.LayNgayKhoiHanhTheoMaChuyenBay(maChuyenBay);

                    // Kiểm tra nếu ngày khởi hành đã qua hoặc là cùng ngày hiện tại
                    if (ngayKhoiHanh.Date <= ngayHienTai)
                    {
                        string trangThai = "Đã hủy";
                        // Cập nhật trạng thái trong cơ sở dữ liệu
                        pdcBus.CapNhatTrangThaiPhieuDatCho(phieuDatChoID, trangThai);
                    }
                }

                MessageBox.Show("Đã hủy tất cả các phiếu đặt chỗ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void KhoDuLieu_Click(object sender, EventArgs e)
        {
            if (TenDangNhap != "admin")
            {
                // Hiển thị thông báo hoặc thực hiện các hành động khác khi người dùng không có quyền truy cập
                // Vô hiệu hóa danh sách con trong
                KhoDuLieu.DropDownItems.Clear();
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.");
                return;
            }
        }
        private void BaoCao_Click(object sender, EventArgs e)
        {
            if (TenDangNhap != "admin")
            {
                // Hiển thị thông báo hoặc thực hiện các hành động khác khi người dùng không có quyền truy cập
                // Vô hiệu hóa danh sách con trong
                BaoCao.DropDownItems.Clear();
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.");
                return;
            }
        }

        private void QD_Click(object sender, EventArgs e)
        {
            if (TenDangNhap != "admin")
            {
                // Hiển thị thông báo hoặc thực hiện các hành động khác khi người dùng không có quyền truy cập
                // Vô hiệu hóa danh sách con trong
                QD.DropDownItems.Clear();
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.");
                return;
            }
        }

        private void ThemNhanVien_Click(object sender, EventArgs e)
        {
            if (TenDangNhap != "admin")
            {
                // Hiển thị thông báo hoặc thực hiện các hành động khác khi người dùng không có quyền truy cập
                // Vô hiệu hóa danh sách con trong
                ThemNhanVien.DropDownItems.Clear();
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.");
                return;
            }
            else
            {
                MH_ThemNhanVien mh = new MH_ThemNhanVien();
                mh.Show();
            }
        }
    }
}


