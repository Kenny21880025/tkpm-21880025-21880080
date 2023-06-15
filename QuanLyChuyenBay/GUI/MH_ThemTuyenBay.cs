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

namespace QuanLyChuyenBay.GUI
{
    public partial class MH_ThemTuyenBay : Form
    {
        SanBayBUS sbBus = new SanBayBUS();
        TuyenBayBUS tbBus = new TuyenBayBUS();
        TuyenBay tb = new TuyenBay();
        public MH_ThemTuyenBay()
        {
            InitializeComponent();
        }
        private void MH_ThemTuyenBay_Load(object sender, EventArgs e)
        {
            cbSanBayDi.SelectedIndexChanged += cbSanBayDi_SelectedIndexChanged; // Đăng ký sự kiện SelectedIndexChanged cho cbSanBayDi
            cbSanBayDen.SelectedIndexChanged += cbSanBayDen_SelectedIndexChanged; // Đăng ký sự kiện SelectedIndexChanged cho cbSanBayDe
            // Đưa các giá trị vào cbSanBayDi
            DataTable dsSanBayDi;
            dsSanBayDi = sbBus.LayDanhSach();
            cbSanBayDi.DataSource = dsSanBayDi;
            cbSanBayDi.DisplayMember = "MaSanBay";
            
            // Đưa các giá trị vào cbSanBayDen
            DataTable dsSanBayDen;
            dsSanBayDen = tbBus.LayCacSBDenKoThoa(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "MaSanBay";
            cbSanBayDi.Text = "";
            lbSanBayDi.Text = "";
            cbSanBayDen.Text = "";
            lbSanBayDen.Text = "";
        }
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {
            DataTable dsSanBayDen = tbBus.LayCacSBDenKoThoa(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "MaSanBay";            
            lbSanBayDi.Text = sbBus.LayTenSanBay(cbSanBayDi.Text);
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
            lbSanBayDi.Text = sbBus.LayTenSanBay(cbSanBayDi.Text);
            if (!string.IsNullOrEmpty(cbSanBayDi.Text) && !string.IsNullOrEmpty(cbSanBayDen.Text))
            {
                txtMaTuyenBay.Text = cbSanBayDi.Text + "-" + cbSanBayDen.Text;
            }
            else
            {
                txtMaTuyenBay.Text = "";
            }
        }
        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSanBayDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
            if (!string.IsNullOrEmpty(cbSanBayDi.Text) && !string.IsNullOrEmpty(cbSanBayDen.Text))
            {
                txtMaTuyenBay.Text = cbSanBayDi.Text + "-" + cbSanBayDen.Text;
            }
            else
            {
                txtMaTuyenBay.Text = "";
            }
        }
        private void btn_ThemTuyenBay_Click(object sender, EventArgs e)
        {
            tb.MaTuyenBay = txtMaTuyenBay.Text;
            tb.SanBayDi = cbSanBayDi.Text;
            tb.SanBayDen = cbSanBayDen.Text;
            // Kiểm tra tuyến bay đã tồn tại hay chưa
            if (tbBus.TuyenBayDaTonTai(tb))
            {
                MessageBox.Show("Tuyến bay đã tồn tại!");
                return;
            }
            var rs = tbBus.ThemTuyenBay(tb);
            if (rs > 0)
            {
                tbBus.LayDSTuyenBay();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                string thongBao = "";
                switch (rs)
                {
                    case -1:
                        thongBao = "Xin chọn sân bay đi";
                        break;
                    case -2:
                        thongBao = "Xin chọn sân bay đến";
                        break;
                    default:
                        break;
                }
                MessageBox.Show(thongBao);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        } 
       }
}
