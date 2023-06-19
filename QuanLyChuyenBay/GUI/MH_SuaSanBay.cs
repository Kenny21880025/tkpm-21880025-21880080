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
    public partial class MH_SuaSanBay : Form
    {
        SanBayBUS sbBus = new SanBayBUS();
        TuyenBay tb = new TuyenBay();
        // Thuộc tính để lưu giá trị mã tuyến bay
        public string MaSanBay { get; set; }
        public MH_SuaSanBay()
        {
            InitializeComponent();
        }

        private void MH_SuaSanBay_Load(object sender, EventArgs e)
        {
            // Gán giá trị mã tuyến bay vào textbox
            txtMaSanBay.Text = MaSanBay;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đã chỉnh sửa
            string TenSanBay = txtTenSanBay.Text;            
            var rs = sbBus.SuaSanBay(TenSanBay);
            if (rs > 0)
            {
                MessageBox.Show("Sửa sân bay thành công");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
