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
using QuanLyChuyenBay.GUI;
namespace QuanLyChuyenBay
{
    public partial class MH_BanVe : Form
    {
        string matuyenbay;
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        HangVeBUS hvBus = new HangVeBUS();
        TinhTrangVeBUS ttvBus = new TinhTrangVeBUS();
        DonGiaBUS dgBus = new DonGiaBUS();
        HanhKhach hk = new HanhKhach();
        HanhKhachBUS hkBus = new HanhKhachBUS();
        HangVe hv = new HangVe();
        DonGia dg = new DonGia();
        ChuyenBay cb = new ChuyenBay();
        VeChuyenBayBUS vcbBus = new VeChuyenBayBUS();
        VeChuyenBay vcb = new VeChuyenBay();
        public MH_BanVe()
        {
            InitializeComponent();
        }

        private void btn_LuuVe_Click(object sender, EventArgs e)
        {
            if (this.txtSanBayDi.Text == "")
            {
                MessageBox.Show("Chưa chọn chuyến bay");
                return;
            }

            if (this.txtMaHanhKhach.Text == "")
            {
                MessageBox.Show("Chưa có hành khách");
                return;
            }
            double gia = 0;
            gia = dgBus.LayDonGia(matuyenbay, cbHangVe.Text);
            dg = new DonGia();
            vcb.MaChuyenBay = cbMaChuyenBay.Text;
            vcb.MaHangVe = cbHangVe.Text;
            vcb.MaHanhKhach = txtMaHanhKhach.Text;
            vcb.GiaTien = gia;
            vcbBus.ThemVeChuyenBay(vcb);
            vcb = new VeChuyenBay();
            // Update seat status            
            ttvBus.CapNhatTinhTrangVe(cbMaChuyenBay.Text, true);
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            txtSanBayDen.Text = "";
            txtSanBayDi.Text = "";
            txtNgayGio.Text = "";
            txtTinhTrangVe.Text = "";
            txtGiaTien.Text = "";
            txtMaHanhKhach.Text = "";
            txtTenHanhKhach.Text = "";
            txtID.Text = "";
            txtGiaTien.Text = "";
            cbMaChuyenBay.Text = "";
        }

        private void btn_ThoatBanVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MH_BanVe_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu vào cbMaChuyenBay            
            DataTable ds = new DataTable();
            ds = cbBus.LayMaCBSauNgay(DateTime.Now);
            cbMaChuyenBay.DataSource = ds;
            cbMaChuyenBay.DisplayMember = "MaChuyenBay";

            cbMaChuyenBay.Text = "";
            txtSanBayDen.Text = "";
            txtSanBayDi.Text = "";
            txtNgayGio.Text = "";
            txtTinhTrangVe.Text = "";
            // Tải hạng vé            
            DataTable dsHangVe = new DataTable();
            dsHangVe = hvBus.LayDSHangVe();
            cbHangVe.DataSource = dsHangVe;
            cbHangVe.DisplayMember = "MaHangVe";
            cbHangVe.Text = dsHangVe.Rows[0][0].ToString();
            txtTenHangVe.Text = dsHangVe.Rows[0][1].ToString();
            txtGiaTien.Text = "";
        }

        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaChuyenBay.Text == "")
            {
                return;
            }
            DataTable ds = new DataTable();
            ds = cbBus.LayDSChuyenBayTheoMa(cbMaChuyenBay.Text);
            txtSanBayDi.Text = ds.Rows[0][0].ToString();
            txtSanBayDen.Text = ds.Rows[0][1].ToString();
            txtNgayGio.Text = ds.Rows[0][2].ToString();
            matuyenbay = ds.Rows[0][3].ToString();
            txtTinhTrangVe.Text = ttvBus.LayTinhTrangVe(cbMaChuyenBay.Text);
            if (cbMaChuyenBay.Text == "" || cbHangVe.Text == "")
            {
                txtGiaTien.Text = "";
                return;
            }
            double gia = 0;
            gia = dgBus.LayDonGia(matuyenbay, cbHangVe.Text);
            txtGiaTien.Text = gia.ToString();
        }

        private void btn_MaHanhKhach_Click(object sender, EventArgs e)
        {
            MH_ThemHanhKhach mhthk = new MH_ThemHanhKhach();
            mhthk.ShowDialog();
            txtMaHanhKhach.Text = mhthk.txtMaHanhKhach.Text;
            txtID.Text = mhthk.txtID.Text;
            txtDienThoai.Text = mhthk.txtDienThoai.Text;
            txtTenHanhKhach.Text = mhthk.txtTenHanhKhach.Text;
        }
        private void txtMaHanhKhach_LostFocus(object sender, EventArgs e)
        {
            if (txtMaHanhKhach.Text == "")
            {
                txtDienThoai.Text = "";
                txtID.Text = "";
                txtTenHanhKhach.Text = "";
                return;
            }
            DataTable ds = new DataTable();
            ds = hkBus.LayHanhKhachTuMa(txtMaHanhKhach.Text);
            hk = new HanhKhach();

            if (ds.Rows.Count == 0)
            {
                return;
            }
            txtTenHanhKhach.Text = ds.Rows[0][0].ToString();
            txtID.Text = ds.Rows[0][1].ToString();
            txtDienThoai.Text = ds.Rows[0][2].ToString();

            if (cbMaChuyenBay.Text == "" || cbHangVe.Text == "")
            {
                txtGiaTien.Text = "";
                return;
            }
            double gia = 0;
            gia = dgBus.LayDonGia(matuyenbay, cbHangVe.Text);
            txtGiaTien.Text = gia.ToString();
        }
        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHangVe.Text == "")
            {
                txtTenHangVe.Text = "";
                return;
            }
            txtTenHangVe.Text = hvBus.LayTenHangVe(cbHangVe.Text);
            hv = new HangVe();

            if (cbMaChuyenBay.Text == "" || cbHangVe.Text == "")
            {
                txtGiaTien.Text = "";
                return;
            }
            double gia = 0;
            gia = dgBus.LayDonGia(matuyenbay, cbHangVe.Text);
            dg = new DonGia();
            txtGiaTien.Text = gia.ToString();
        }
        private void btn_HangVe_Click(object sender, EventArgs e)
        {
            MH_ThemHangVe mhthv = new MH_ThemHangVe();
            mhthv.ShowDialog();
            DataTable ds = new DataTable();
            ds = cbBus.LayMaCBSauNgay(DateTime.Now);
            cb = new ChuyenBay();
            cbMaChuyenBay.DataSource = ds;
            cbMaChuyenBay.DisplayMember = "MaChuyenBay";
        }
    }
}
