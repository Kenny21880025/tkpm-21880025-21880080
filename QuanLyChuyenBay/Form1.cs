namespace QuanLyChuyenBay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void grevLichBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}