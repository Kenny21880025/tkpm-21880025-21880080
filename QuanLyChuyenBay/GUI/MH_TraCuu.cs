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

namespace QuanLyChuyenBay
{
    public partial class MH_TraCuu : Form
    {
        SanBayBUS sbBus = new SanBayBUS();
        SanBay sb = new SanBay();
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        ChuyenBay cb = new ChuyenBay();
        TuyenBayBUS tbBus = new TuyenBayBUS();
        DataTable dsSanBayDi = new DataTable();
        DataTable dsSanBayDen = new DataTable();
        DataTable dsChuyenBay = new DataTable();
        DataTable dscb = new DataTable();
        public MH_TraCuu()
        {
            InitializeComponent();
        }
        Font customFont = new Font("Arial", 20, FontStyle.Bold);
        private void MH_TraCuu_Load(object sender, EventArgs e)
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
            lbTenSBDen.Text = "";
            cbSanBayDen.Text = "";
            lbTenSBDen.Text = "";
            dsChuyenBay = cbBus.LayTDTraCuu(true);
            grvChuyenBay.DataSource = dsChuyenBay;
        }
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {
            dsSanBayDen = tbBus.LayBangSBDenChoTuyenBay(cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
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
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dscb = cbBus.TimChuyenBay(cbSanBayDi.Text, cbSanBayDen.Text, dtpTu.Value, dtpDen.Value);
            if (dscb.Rows.Count == 0)
            {
                MessageBox.Show("Không có chuyến bay phù hợp.");
            }
            else
            {
                grvChuyenBay.DataSource = dscb;
            }
        }
        private void grvChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
