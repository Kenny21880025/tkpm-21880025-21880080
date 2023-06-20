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
    public partial class MH_SuaTuyenBay : Form
    {
        TuyenBayBUS tbBus = new TuyenBayBUS();
        TuyenBay tb = new TuyenBay();
        // Thuộc tính để lưu giá trị mã tuyến bay
        public string MaTuyenBay { get; set; }        
        public MH_SuaTuyenBay()
        {
            InitializeComponent();
           
        }
        private void MH_SuaTuyenBay_Load(object sender, EventArgs e)
        {
            // Gán giá trị mã tuyến bay vào textbox
            txtMaTuyenBay.Text = MaTuyenBay;
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đã chỉnh sửa
            string SanBayDi = txtSanBayDi.Text;
            string SanBayDen = txtSanBayDen.Text;
            tb.MaTuyenBay = MaTuyenBay;
            tb.SanBayDi = SanBayDi;
            tb.SanBayDen = SanBayDen;            
            var rs = tbBus.SuaTuyenBay(tb);
            if (rs > 0)
            {
                MessageBox.Show("Sửa tuyến bay thành công");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {           
            Close();
        }
    }
}
