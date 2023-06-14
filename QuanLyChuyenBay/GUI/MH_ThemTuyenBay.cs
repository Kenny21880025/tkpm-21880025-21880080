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
        public MH_ThemTuyenBay()
        {
            InitializeComponent();
        }
        private void MH_ThemTuyenBay_Load(object sender, EventArgs e)
        {
            DataTable dsSanBayDi;
            //SanBay sb = new SanBay();

            dsSanBayDi = sbBus.LayDanhSach();
            cbSanBayDi.DataSource = dsSanBayDi;
            cbSanBayDi.DisplayMember = "TenSanBay";

            DataTable dsSanBayDen;
            //TuyenBay tb = new TuyenBay();
            dsSanBayDen = tbBus.LayCacSBDenKoThoa(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "TenSanBay";
            cbSanBayDi.Text = "";
            lbSanBayDi.Text = "";
            cbSanBayDen.Text = "";
            lbSanBayDen.Text = "";
        }
        private void btn_ThemTuyenBay_Click(object sender, EventArgs e)
        {            
            var rs = tbBus.ThemTuyenBay(txtMaTuyenBay.Text, cbSanBayDi.Text, cbSanBayDen.Text);
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

        
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {
            DataTable dsSanBayDen;
            TuyenBay tb = new TuyenBay();
            dsSanBayDen = tbBus.LayCacSBDenKoThoa(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "TenSanBay";
            SanBay sb = new SanBay();
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
            cbSanBayDen.DisplayMember = "TenSanBay"; // Chỉ định tên cột chứa tên sân bay
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
    }
}
