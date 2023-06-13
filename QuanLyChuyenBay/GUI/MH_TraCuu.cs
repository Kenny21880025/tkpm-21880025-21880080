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
        public MH_TraCuu()
        {
            InitializeComponent();
        }
        Font customFont = new Font("Arial", 20, FontStyle.Bold);
        private void MH_TraCuu_Load(object sender, EventArgs e)
        {
            // Đưa các giá trị vào cbSanBayDi
            DataTable dsSanBayDi = sbBus.LayDSSanBay();
            sb = new SanBay();

            cbSanBayDi.DataSource = dsSanBayDi;
            cbSanBayDi.DisplayMember = "MaSanBay";
            cbSanBayDi.Text = dsSanBayDi.Rows[0][0].ToString();
            DataTable ds = cbBus.LayTDTraCuu(true);
            cb = new ChuyenBay();
            grvChuyenBay.DataSource = ds;
        }
        private void cbSanBayDi_LostFocus(object sender, EventArgs e)
        {
            DataTable dsSanBayDen = tbBus.ChonTuyenBay(true, cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
            sb = new SanBay();
        }

        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dsSanBayDen;
            dsSanBayDen = tbBus.ChonTuyenBay(true, cbSanBayDi.Text);
            cbSanBayDen.DataSource = dsSanBayDen;
            cbSanBayDen.DisplayMember = "SanBayDen";
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
            lbTenSBDi.Text = sbBus.LayTenSanBay(cbSanBayDi.Text);
            sb = new SanBay();
        }
        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenSBDen.Text = sbBus.LayTenSanBay(cbSanBayDen.Text);
            sb = new SanBay();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            DataTable dscb;
            dscb = cbBus.TimChuyenBay(cbSanBayDi.Text, cbSanBayDen.Text, dtpTu.Value, dtpDen.Value);
            cb = new ChuyenBay();
            grvChuyenBay.DataSource = dscb;
        }
        private void grvChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
