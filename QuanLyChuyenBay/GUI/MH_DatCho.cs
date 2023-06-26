using QuanLyChuyenBay.BUS;
using QuanLyChuyenBay.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class MH_DatCho : Form
    {
        string MaTuyenBay;
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        HangVeBUS hvBus = new HangVeBUS();
        TinhTrangVeBUS ttvBus = new TinhTrangVeBUS();
        DonGiaBUS dgBus = new DonGiaBUS();
        HanhKhach hk = new HanhKhach();
        HanhKhachBUS hkBus = new HanhKhachBUS();
        HangVe hv = new HangVe();
        DonGia dg = new DonGia();
        ChuyenBay cb = new ChuyenBay();
        PhieuDatChoBUS vcbBus = new PhieuDatChoBUS();
        PhieuDatCho vcb = new PhieuDatCho();
        DataTable ds = new DataTable();
        DataTable thongtinkhach = new DataTable();
        DataTable dsHangVe = new DataTable();
        DataTable dsHanhKhach = new DataTable();
        private bool isLoaded = false;
        private bool isInitialized = false;
        public MH_DatCho()
        {
            InitializeComponent();
        }

        private void MH_DatCho_Load(object sender, EventArgs e)
        {
            /// Lấy dữ liệu vào cbMaChuyenBay          
            ds = cbBus.LayMaCBSauNgay(DateTime.Now);
            cbMaChuyenBay.DataSource = ds;
            cbMaChuyenBay.DisplayMember = "MaChuyenBay";
            cbMaChuyenBay.SelectedItem = null; // Xóa giá trị được chọn
            isLoaded = true;
            isInitialized = true;

            cbMaChuyenBay.Text = "";
            txtSanBayDen.Text = "";
            txtSanBayDi.Text = "";
            txtNgayGio.Text = "";
            txtTinhTrangVe.Text = "";

            // Tải hạng vé
            dsHangVe = hvBus.LayDSHangVe();
            cbHangVe.DataSource = dsHangVe;
            cbHangVe.DisplayMember = "Mã Hạng Vé";
            cbHangVe.Text = dsHangVe.Rows[0][0].ToString();            
            //cbHangVe.Text = "";
            //txtTenHangVe.Text = "";
            //txtGiaTien.Text = "";

            // Tải hành khách
            dsHanhKhach = hkBus.LayDanhSach();
            cbMaHanhKhach.DataSource = dsHanhKhach;
            cbMaHanhKhach.DisplayMember = "MaHanhKhach";
            cbMaHanhKhach.Text = dsHanhKhach.Rows[0][0].ToString();
            txtTenHanhKhach.Text = dsHanhKhach.Rows[0][1].ToString();
            txtID.Text = dsHanhKhach.Rows[0][1].ToString();
            txtDienThoai.Text = dsHanhKhach.Rows[0][3].ToString();
            cbMaHanhKhach.Text = "";
            txtTenHanhKhach.Text = "";
            txtID.Text = "";
            txtDienThoai.Text = "";

            // Gắn kết sự kiện SelectedIndexChanged cho cbMaChuyenBay và cbHangVe
            cbMaChuyenBay.SelectedIndexChanged += cbMaChuyenBay_SelectedIndexChanged;
            cbHangVe.SelectedIndexChanged += cbHangVe_SelectedIndexChanged;
            cbMaHanhKhach.SelectedIndexChanged += cbMaHanhKhach_SelectedIndexChanged;
        }

        private void btn_LuuCho_Click(object sender, EventArgs e)
        {
            if (txtSanBayDi.Text == "")
            {
                MessageBox.Show("Chưa chọn chuyến bay");
                return;
            }
            if (cbMaHanhKhach.Text == "")
            {
                MessageBox.Show("Chưa có hành khách");
                return;
            }
            // Kiểm tra tình trạng vé trước khi bán
            if (txtTinhTrangVe.Text != "Còn chỗ")
            {
                MessageBox.Show("Ghế đã được đặt hết, không thể bán vé.");
                return;
            }
            // Kiểm tra ngày khởi hành
            DateTime ngayKhoiHanh = DateTime.Parse(txtNgayGio.Text);
            DateTime ngayHienTai = DateTime.Now.Date;
            TimeSpan timeSpan = ngayKhoiHanh - ngayHienTai;
            int soNgayConLai = timeSpan.Days;

            if (soNgayConLai < 1)
            {
                MessageBox.Show("Không thể đặt vé vào ngày khởi hành. Vui lòng chọn ngày khác.");
                return;
            }
            vcb.MaChuyenBay = cbMaChuyenBay.Text;
            vcb.MaHangVe = cbHangVe.Text;
            vcb.MaHanhKhach = cbMaHanhKhach.Text;
            vcb.GiaTien = double.Parse(txtGiaTien.Text);
            vcb.NgayDat = dtpNgayDat.Value;
            
            var rs = vcbBus.ThemPhieuDatCho(vcb);
            if (rs > 0)
            {
                MessageBox.Show("Đặt chỗ thành công!");
            }
            else
            {
                MessageBox.Show("Đặt chỗ không thành công!");
            }
            // Cập nhật tình trạng vé         
            ttvBus.CapNhatTinhTrangVe(cbMaChuyenBay.Text, true);
        }
        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded || !isInitialized)
            {
                return;
            }
            if (cbMaChuyenBay.Text == "")
            {
                return;
            }
            ds = cbBus.LayDSChuyenBayTheoMa(cbMaChuyenBay.Text);
            if (ds.Rows.Count == 0)
            {
                // Không có dữ liệu phù hợp
                MessageBox.Show("Không tìm thấy dữ liệu chuyến bay phù hợp.");
                return;
            }
            txtSanBayDi.Text = ds.Rows[0][0].ToString();
            txtSanBayDen.Text = ds.Rows[0][1].ToString();
            txtNgayGio.Text = ds.Rows[0][2].ToString();
            MaTuyenBay = ds.Rows[0][3].ToString();
            txtTinhTrangVe.Text = ttvBus.LayTinhTrangVe(cbMaChuyenBay.Text);
            DataTable dsGia = dgBus.LayDanhSach(MaTuyenBay, cbHangVe.Text);
            txtGiaTien.Text = dsGia.Rows[0]["Gia"].ToString();
        }
        private void txtMaHanhKhach_LostFocus(object sender, EventArgs e)
        {            
        }
        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHangVe.Text == "")
            {
                return;
            } 
            DataTable dsGia = dgBus.LayDanhSach(MaTuyenBay, cbHangVe.Text);
            txtGiaTien.Text = dsGia.Rows[0]["Gia"].ToString();
        }
        private void btn_TaoPhieuMoi_Click(object sender, EventArgs e)
        {
            txtSanBayDen.Text = "";
            txtSanBayDi.Text = "";
            txtNgayGio.Text = "";
            txtTinhTrangVe.Text = "";
            txtGiaTien.Text = "";
            cbMaHanhKhach.Text = "";
            txtTenHanhKhach.Text = "";
            txtID.Text = "";
            txtGiaTien.Text = "";
            cbMaChuyenBay.Text = "";
        }
        private void btn_MaHanhKhach_Click(object sender, EventArgs e)
        {
            MH_ThemHanhKhach mhthk = new MH_ThemHanhKhach();
            mhthk.Show();
            cbMaHanhKhach.Text = mhthk.txtMaHanhKhach.Text;
            txtID.Text = mhthk.txtID.Text;
            txtDienThoai.Text = mhthk.txtDienThoai.Text;
            txtTenHanhKhach.Text = mhthk.txtTenHanhKhach.Text;
        }
        private void btn_ThoatDatCho_Click(object sender, EventArgs e)
        {
            Close();
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
        private void cbMaHanhKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaHanhKhach.Text == "")
            {
                return;
            }
            if (cbMaHanhKhach.Text == "")
            {
                txtDienThoai.Text = "";
                txtID.Text = "";
                txtTenHanhKhach.Text = "";
                return;
            }
            thongtinkhach = hkBus.LayHanhKhachTuMa(cbMaHanhKhach.Text);
            //hk = new HanhKhach();
            if (thongtinkhach.Rows.Count == 0)
            {
                return;
            }
            txtTenHanhKhach.Text = thongtinkhach.Rows[0][0].ToString();
            txtID.Text = thongtinkhach.Rows[0][1].ToString();
            txtDienThoai.Text = thongtinkhach.Rows[0][2].ToString();
        }
    }
}
