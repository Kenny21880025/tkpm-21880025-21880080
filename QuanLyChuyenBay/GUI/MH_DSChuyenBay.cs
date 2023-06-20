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
    public partial class MH_DSChuyenBay : Form
    {
        ChuyenBayBUS cbBus = new ChuyenBayBUS();
        string mcb;
        public MH_DSChuyenBay()
        {
            InitializeComponent();
            mcb = txtMaChuyenBay.Text;
        }

        private void btn_LayDanhSach_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = cbBus.LayDanhSach();
            grvChuyenBay.DataSource = bang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_NhanLich mhnl = new MH_NhanLich();
            mhnl.Show();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            mcb = txtMaChuyenBay.Text;
            if (string.IsNullOrEmpty(mcb))
            {
                MessageBox.Show("Vui lòng nhập mã chuyến bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }
            var rs = cbBus.XoaChuyenBay(mcb);
            if (rs > 0)
            {
                MessageBox.Show("Xóa hành khách thành công");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            mcb = txtMaChuyenBay.Text;
            if (string.IsNullOrEmpty(mcb))
            {
                MessageBox.Show("Vui lòng nhập mã chuyến bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }
            MH_SuaChuyenBay mhscb = new MH_SuaChuyenBay();
            mhscb.MaChuyenBay = txtMaChuyenBay.Text;
            mhscb.Show();
        }

        private void MH_DSChuyenBay_Load(object sender, EventArgs e)
        {           
            
        }
    }
}
