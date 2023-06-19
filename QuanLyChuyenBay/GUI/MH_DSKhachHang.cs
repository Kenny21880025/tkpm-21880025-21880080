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
    public partial class MH_DSKhachHang : Form
    {
        HanhKhachBUS hkBus = new HanhKhachBUS();
        string mhk;
        public MH_DSKhachHang()
        {
            InitializeComponent();
            mhk = txtMaHanhKhach.Text;
        }

        private void btn_LayDS_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = hkBus.LayDanhSach();
            grvKhachHang.DataSource = bang;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_ThemHanhKhach mh = new MH_ThemHanhKhach();
            mh.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            mhk = txtMaHanhKhach.Text;
            if (string.IsNullOrEmpty(mhk))
            {
                MessageBox.Show("Vui lòng nhập mã hành khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            var rs = hkBus.XoaHanhKhach(mhk);
            if (rs > 0)
            {
                MessageBox.Show("Xóa hành khách thành công");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mtb = txtMaHanhKhach.Text;

            if (string.IsNullOrEmpty(mtb))
            {
                MessageBox.Show("Vui lòng nhập mã hành khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            MH_SuaHanhKhach mh = new MH_SuaHanhKhach();
            mh.MaHanhKhach = mhk; // Gán giá trị mã hành khách vào thuộc tính MaTuyenBay
            mh.ShowDialog();
        }
    }
}
