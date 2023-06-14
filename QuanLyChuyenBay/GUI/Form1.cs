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
        private void doanhThuThang_Click(object sender, EventArgs e)
        {
            MH_BaoCaoThang mhbct = new MH_BaoCaoThang();
            mhbct.Show();
            Close(); // Đóng form hiện tại
        }

        private void doanhThuNam_Click(object sender, EventArgs e)
        {
            MH_BaoCaoNam mhbcn = new MH_BaoCaoNam();
            mhbcn.Show();
            Close(); // Đóng form hiện tại
        }

        private void btn_NhanLich_Click(object sender, EventArgs e)
        {
            MH_NhanLich mhnl = new MH_NhanLich();
            mhnl.Show();
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

        private void grvLichBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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


        private void btn_LayDanhSachChuyenBay_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            var bang = cbDb.LayDanhSach();
            grvLichBay.DataSource = bang;
        }
        private void menuXinChao_Click(object sender, EventArgs e)
        {
            menuXinChao.Text = "Xin chào, " + TenDangNhap;
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            menuXinChao.Text = "Xin chào, " + TenDangNhap;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_BanVe_Click_1(object sender, EventArgs e)
        {

        }
    }
}


