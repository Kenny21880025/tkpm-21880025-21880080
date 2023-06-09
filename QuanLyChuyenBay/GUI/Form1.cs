using QuanLyChuyenBay.BUS;
using QuanLyChuyenBay.DAO;

namespace QuanLyChuyenBay
{
    public partial class Form1 : Form
    {
        ChuyenBayBUS cbDb = new ChuyenBayBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NhanLich_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            MH_NhanLich mhnl = new MH_NhanLich();
            mhnl.Show();
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

        private void doanhThuThang_Click(object sender, EventArgs e)
        {
            MH_BaoCaoThang mhbct = new MH_BaoCaoThang();
            mhbct.Show();
        }

        private void doanhThuNam_Click(object sender, EventArgs e)
        {
            MH_BaoCaoNam mhbcn = new MH_BaoCaoNam();
            mhbcn.Show();
        }

        private void grvLichBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QD1_Click(object sender, EventArgs e)
        {

        }

        private void QD2_Click(object sender, EventArgs e)
        {

        }

        private void QD3_Click(object sender, EventArgs e)
        {

        }
    }
}