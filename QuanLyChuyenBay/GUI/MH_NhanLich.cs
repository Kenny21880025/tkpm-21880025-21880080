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
        TinhTrangVeBUS ttvBus = new TinhTrangVeBUS();
        DataTable dsSanBayDi = new DataTable();
        DataTable dsSanBayDen = new DataTable();
        ChiTietChuyenBay ctcb = new ChiTietChuyenBay();
        DataTable dsCTChuyenBay = new DataTable();
        ChiTietChuyenBayBUS ctcbBus = new ChiTietChuyenBayBUS();
        public MH_NhanLich()
        {
            InitializeComponent();
        }

        private void MH_NhanLich_Load(object sender, EventArgs e)
        {
            cbSanBayDi.SelectedIndexChanged += cbSanBayDi_SelectedIndexChanged; // Đăng ký sự kiện SelectedIndexChanged cho cbSanBayDi            
            cbSanBayDen.SelectedIndexChanged += cbSanBayDen_SelectedIndexChanged; // Đăng ký sự kiện SelectedIndexChanged cho cbSanBayDen                                                                                  

            // Đưa các giá trị vào cbSanBayDi       
            dsSanBayDi = sbBus.LayDanhSach();
            cbSanBayDi.DataSource = dsSanBayDi;
            cbSanBayDi.DisplayMember = "MaSanBay";
            
            // Đưa các giá trị vào cbSanBayDen            
            dsSanBayDen = tbBus.LayBangSBDenChoLichBay(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            cbSanBayDi.Text = "";
            lbSanBayDi.Text = "";
            cbSanBayDen.Text = "";
            lbSanBayDen.Text = "";

            // Điền tiêu đề các cột vào dsSanBayTrungGian            
            dsCTChuyenBay = ctcbBus.LayTDChiTietChuyenBay();
            grvSanBayTrungGian.DataSource = dsCTChuyenBay;
            lbTenSBDen.Text = "";
            lbTenSBDi.Text = "";
        }
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {            
            dsSanBayDen = tbBus.LayBangSBDenChoTuyenBay(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
        }
        private void cbSanBayDi_GotFocus(object sender, EventArgs e)
        {
            cbSanBayDen.Text = "";
            lbSanBayDen.Text = "";
        }
        private void cbSanBayDen_LostFocus(object sender, EventArgs e)
        {
            lbSanBayDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
        }
        
        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenSBDi.Text = sbBus.LayTenSanBay(cbSanBayDi.Text);
            string sanBayDi = cbSanBayDi.Text;
            dsSanBayDen = tbBus.LayBangSBDenChoLichBay(sanBayDi);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
        }

        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
            
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
            //DataTable dsCTChuyenBay;
            //ChiTietChuyenBayBUS ctcb = new ChiTietChuyenBayBUS();
            //dsCTChuyenBay = ctcb.LayTDChiTietChuyenBay();
            //grvSanBayTrungGian.DataSource = dsCTChuyenBay;
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
            if (txtThoiGianBay.Text == "")
            {
                MessageBox.Show("Chưa nhập thời gian bay");
                return;
            }
            if (txtGheHang1.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng");
                return;
            }
            if (txtGheHang2.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng");
                return;
            }
            // Lưu thông tin chuyến bay  

            string matb = tbBus.LayMaTuyenBay(cbSanBayDi.Text, cbSanBayDen.Text);
            cb.MaChuyenBay = txtMaChuyenBay.Text;
            cb.MaTuyenBay = matb;
            cb.NgayGio = dtpNgayGio.Value;
            cb.ThoiGianBay = Convert.ToInt32(txtThoiGianBay.Text);
            cb.SoLuongGheHang1 = Convert.ToInt32(txtGheHang1.Text);
            cb.SoLuongGheHang2 = Convert.ToInt32(txtGheHang2.Text);
            var rs = cbBus.ThemChuyenBay(cb);
            // Thêm vào tình trạng vé
            int SoGheDat = 0;
            ttvBus.ThemTinhTrangVe(txtMaChuyenBay.Text, Convert.ToInt32(txtGheHang1.Text) + Convert.ToInt32(txtGheHang2.Text), SoGheDat);
            if (rs > 0)
            {
                sbBus.LayDSSanBay();
                //Luu thong tin chi tiet chuyen bay (cac san bay trung gian)            
                int rowCount = grvSanBayTrungGian.Rows.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    var sanBayTrungGianCell = grvSanBayTrungGian.Rows[i].Cells["Sân Bay Trung Gian"].Value;
                    var thoiGianDungCell = grvSanBayTrungGian.Rows[i].Cells["Thời Gian Dừng"].Value;
                    var ghiChuCell = grvSanBayTrungGian.Rows[i].Cells["Ghi Chú"].Value;

                    if (sanBayTrungGianCell != null && !string.IsNullOrEmpty(sanBayTrungGianCell.ToString().Trim()) &&
                        thoiGianDungCell != null && !string.IsNullOrEmpty(thoiGianDungCell.ToString().Trim()) &&
                        ghiChuCell != null && !string.IsNullOrEmpty(ghiChuCell.ToString().Trim()))
                    {
                        ctcb.MaChuyenBay = cb.MaChuyenBay;
                        ctcb.SanBayTrungGian = sanBayTrungGianCell.ToString();
                        ctcb.ThoiGianDung = short.Parse(thoiGianDungCell.ToString());
                        ctcb.GhiChu = ghiChuCell.ToString();

                        // Gọi phương thức ThemCTChuyenBay với các tham số tương ứng
                        ctcbBus.ThemCTChuyenBay(ctcb);                        
                    }
                    else
                    {                        
                        break; // Bỏ qua vòng lặp for
                    }                    
                }
                MessageBox.Show("Thêm thành công!");
            }
            
            
            
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
        
        private void btn_SanBayDen_Click(object sender, EventArgs e)
        {
            MH_ThemTuyenBay mhttb = new MH_ThemTuyenBay();
            mhttb.Show();
        }
        private void grvSanBayTrungGian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grvSanBayTrungGian_Shown(object sender, EventArgs e)
        {

        }
    }
}
