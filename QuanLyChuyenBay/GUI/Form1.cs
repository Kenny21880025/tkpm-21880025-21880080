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
            menuXinChao.Text = "Xin chào, " + TenDangNhap;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            menuXinChao.Text = "Xin chào, " + TenDangNhap;
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
    }
}


