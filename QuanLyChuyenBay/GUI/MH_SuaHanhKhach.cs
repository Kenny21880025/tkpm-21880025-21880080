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
    public partial class MH_SuaHanhKhach : Form
    {
        HanhKhachBUS hkBus = new HanhKhachBUS();
        public string MaHanhKhach { get; set; }
        public MH_SuaHanhKhach()
        {
            InitializeComponent();
        }

        private void MH_SuaHanhKhach_Load(object sender, EventArgs e)
        {
            // Gán giá trị mã tuyến bay vào textbox
            txtMaHanhKhach.Text = MaHanhKhach;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đã chỉnh sửa
            string mhk = txtMaHanhKhach.Text;
            string SDT = txtDienThoai.Text;
            string ID = txtID.Text;
            var rs = hkBus.SuaHanhKhach(mhk, SDT,ID);
            if (rs > 0)
            {
                MessageBox.Show("Sửa hạng vé thành công");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
