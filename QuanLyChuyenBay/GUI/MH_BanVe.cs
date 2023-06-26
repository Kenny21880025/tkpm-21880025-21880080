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
using System.Diagnostics;

namespace QuanLyChuyenBay
{
    public partial class MH_BanVe : Form
    {
        string MaTuyenBay;
        SanBayBUS sbBus = new SanBayBUS();
        PhieuDatChoBUS pdcBus = new PhieuDatChoBUS();
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
        DataTable ds = new DataTable();
        DataTable thongtinkhach = new DataTable();
        DataTable dsHangVe = new DataTable();
        DataTable dsHanhKhach = new DataTable();
        private bool isLoaded = false;
        private bool isInitialized = false;
        public MH_BanVe()
        {
            InitializeComponent();
        }
        private void btn_LuuVe_Click(object sender, EventArgs e)
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
            vcb.NgayBan = dtpNgayBan.Value;
            var rs = vcbBus.ThemVeChuyenBay(vcb);
            if (rs > 0)
            {
                MessageBox.Show("Thêm vé thành công!");
            }
            else
            {
                MessageBox.Show("Thêm vé không thành công!");
            }
            // Cập nhật tình trạng vé         
            ttvBus.CapNhatTinhTrangVe(cbMaChuyenBay.Text, true);
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
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
            txtDienThoai.Text = "";
            txtTenHangVe.Text = "";
        }
        private void MH_BanVe_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu vào cbMaChuyenBay          
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
            txtTenHangVe.Text = dsHangVe.Rows[0][1].ToString();
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
        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHangVe.Text == "")
            {
                return;
            }
            var tenHangVe = hvBus.LayTenHangVe(cbHangVe.Text);
            txtTenHangVe.Text = tenHangVe;
            DataTable dsGia = dgBus.LayDanhSach(MaTuyenBay, cbHangVe.Text);
            txtGiaTien.Text = dsGia.Rows[0]["Gia"].ToString();
        }
        private void btn_MaHanhKhach_Click(object sender, EventArgs e)
        {
            MH_ThemHanhKhach mhthk = new MH_ThemHanhKhach();
            mhthk.ShowDialog();
            cbMaHanhKhach.Text = mhthk.txtMaHanhKhach.Text;
            txtID.Text = mhthk.txtID.Text;
            txtDienThoai.Text = mhthk.txtDienThoai.Text;
            txtTenHanhKhach.Text = mhthk.txtTenHanhKhach.Text;
        }
        private void txtMaHanhKhach_LostFocus(object sender, EventArgs e)
        {

        }
        private void btn_HangVe_Click(object sender, EventArgs e)
        {
            MH_ThemHangVe mhthv = new MH_ThemHangVe();
            mhthv.ShowDialog();
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
        private void btn_ThoatBanVe_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_HangVe_Click_1(object sender, EventArgs e)
        {
            int soLuongHangVe = Convert.ToInt32(sbBus.LayThamSo().Rows[0]["SLHangVe"]);
            int soLuongHangVeDemDuoc = hvBus.LayDanhSach().Rows.Count;
            if (soLuongHangVeDemDuoc >= soLuongHangVe)
            {
                MessageBox.Show("Số lượng hạng vé đã đủ " + soLuongHangVe + ". Không thể thêm hạng vé mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MH_ThemHangVe mh = new MH_ThemHangVe();
                mh.Show();
            }
        }
        private void btn_XuatVe_Click(object sender, EventArgs e)
        {
            if (cbMaHanhKhach.Text == "")
            {
                MessageBox.Show("Chưa chọn mã hành khách");
                return;
            }

            // Truy vấn phiếu đặt chỗ dựa trên mã hành khách
            string maHanhKhach = cbMaHanhKhach.Text;
            DataTable phieuDatCho = pdcBus.LayPhieuTheoMa(maHanhKhach);
            if (phieuDatCho == null)
            {
                MessageBox.Show("Không tìm thấy phiếu đặt chỗ cho mã hành khách này");
                return;
            }

            // Điền thông tin từ phiếu đặt chỗ vào form MH_BanVe
            cbMaChuyenBay.Text = phieuDatCho.Rows[0]["MaChuyenBay"].ToString();

            // Lưu vé vào cơ sở dữ liệu
            vcb.MaChuyenBay = cbMaChuyenBay.Text;
            vcb.MaHangVe = cbHangVe.Text;
            vcb.MaHanhKhach = cbMaHanhKhach.Text;
            vcb.GiaTien = double.Parse(txtGiaTien.Text);
            vcb.NgayBan = dtpNgayBan.Value;
            vcb.TrangThai = "Đã xuất vé";

            int result = vcbBus.ThemVeChuyenBay(vcb);
            pdcBus.CapNhatPhieuSauKhiXuatVe(maHanhKhach, vcb.TrangThai);
            if (result > 0)
            {
                MessageBox.Show("Xuất vé thành công!");
            }
            else
            {
                MessageBox.Show("Xuất vé không thành công!");
            }
        }
    }
}
