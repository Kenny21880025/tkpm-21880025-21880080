using QuanLyChuyenBay.BUS;
using QuanLyChuyenBay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay.GUI;

namespace QuanLyChuyenBay
{
    public partial class MH_NhanLich : Form
    {
        ChuyenBay cb = new ChuyenBay();
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        SanBayBUS sbBus = new SanBayBUS();
        TuyenBayBUS tbBus = new TuyenBayBUS();
        ChiTietChuyenBayBUS ctcbBUS = new ChiTietChuyenBayBUS();
        TinhTrangVeBUS ttvBus = new TinhTrangVeBUS();
        public MH_NhanLich()
        {
            InitializeComponent();
        }

        private void MH_NhanLich_Load(object sender, EventArgs e)
        {
            // Đưa các giá trị vào cbSanBayDi
            DataTable dsSanBayDi;
            dsSanBayDi = sbBus.LayDanhSach();
            cbSanBayDi.DataSource = dsSanBayDi;
            cbSanBayDi.DisplayMember = "MaSanBay";
            cbSanBayDi.Text = "";
            // Điền tiêu đề các cột vào dsSanBayTrungGian
            DataTable dsCTChuyenBay;
            ChiTietChuyenBayBUS ctcbBus = new ChiTietChuyenBayBUS();
            dsCTChuyenBay = ctcbBus.LayTDChiTietChuyenBay();
            grvSanBayTrungGian.DataSource = dsCTChuyenBay;
            lbTenSBDen.Text = "";
            lbTenSBDi.Text = "";
        }
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {
            DataTable dsSanBayDen;
            dsSanBayDen = tbBus.ChonTuyenBay(true, cbSanBayDi.Text);

            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            lbTenSBDen.Text =
            sbBus.LayTenSanBay(cbSanBayDen.Text);
        }
        private void btn_LuuLichBay_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text == "")
            {
                MessageBox.Show("Chưa nhập mã chuyến bay");
                return;
            }
            if (!cbBus.KiemTraChuyenBay(txtMaChuyenBay.Text))
            {
                MessageBox.Show("Mã Chuyến Bay đã tồn tại. Chọn mã khác!");
                return;
            }
            if (cbSanBayDi.Text == "")
            {
                MessageBox.Show("Chưa chọn sân bay đi");
                return;
            }
            if (cbSanBayDen.Text == "")
            {
                MessageBox.Show("Chưa chọn sân bay đến");
                return;
            }
            // Lưu thông tin chuyến bay
            string matb;
            matb = tbBus.LayMaTuyenBay(cbSanBayDi.Text, cbSanBayDen.Text);
            cb.MaChuyenBay = txtMaChuyenBay.Text;
            cb.MaChuyenBay = matb;
            cb.NgayGio = dtpNgayGio.Value;
            cb.ThoiGianBay = Convert.ToInt32(txtThoiGianBay.Text);
            cb.SoLuongGheHang1 = Convert.ToInt32(txtGheHang1.Text);
            cb.SoLuongGheHang2 = Convert.ToInt32(txtGheHang2.Text);
            cbBus.ThemChuyenBay(cb);
            //Luu thong tin chi tiet chuyen bay (cac san bay trung gian)
            ChiTietChuyenBay ctcb = new ChiTietChuyenBay();
            int rowCount = grvSanBayTrungGian.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                ctcb.MaChuyenBay = txtMaChuyenBay.Text;
                //ctcb.SanBayTrungGian = grvSanBayTrungGian.Rows[i].Cells["SanBayTrungGian"].Value.ToString();
                //ctcb.ThoiGianDung = short.Parse(grvSanBayTrungGian.Rows[i].Cells["ThoiGianDung"].Value.ToString());
                //ctcb.GhiChu = grvSanBayTrungGian.Rows[i].Cells["GhiChu"].Value.ToString();

                // Call the ThemCTChuyenBay method passing the appropriate arguments
                ctcbBUS.ThemCTChuyenBay(ctcb);
            }
            // Thêm vào tình trạng vé            
            ttvBus.ThemTinhTrangVe(txtMaChuyenBay.Text, Convert.ToInt32(txtGheHang1.Text) + Convert.ToInt32(txtGheHang2.Text));
        }
        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenSBDi.Text = sbBus.LayTenSanBay(cbSanBayDi.Text);
        }

        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenSBDen.Text =    sbBus.LayTenSanBay(cbSanBayDen.Text);
        }
        private void btn_ThemLichBay_Click(object sender, EventArgs e)
        {
            txtMaChuyenBay.Text = "";
            txtGheHang1.Text = "";
            txtGheHang2.Text = "";
            txtThoiGianBay.Text = "";
            cbSanBayDen.Text = "";
            cbSanBayDen.DataSource = null;
            grvSanBayTrungGian.DataSource = null;
            cbSanBayDi.Text = "";
            lbTenSBDi.Text = "";

            DataTable dsCTChuyenBay;
            ChiTietChuyenBayBUS ctcb = new ChiTietChuyenBayBUS();
            dsCTChuyenBay = ctcb.LayTDChiTietChuyenBay();
            grvSanBayTrungGian.DataSource = dsCTChuyenBay;
        }
        private void btn_ThoatLichBay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SanBayDi_Click(object sender, EventArgs e)
        {
            MH_ThemSanBay mhtsb = new MH_ThemSanBay();
            mhtsb.Show();
        }
        private void cbSanBayDi_GotFocus(object sender, EventArgs e)
        {
            cbSanBayDen.Text = "";
            lbTenSBDen.Text = "";
        }

        private void btn_SanBayDen_Click(object sender, EventArgs e)
        {
            
        }

        private void grvSanBayTrungGian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grvSanBayTrungGian_Shown(object sender, EventArgs e)
        {

        }
    }
}
