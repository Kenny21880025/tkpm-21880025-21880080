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
    public partial class MH_DSSanBay : Form
    {
        SanBayBUS sbBus = new SanBayBUS();
        string msb;
        public MH_DSSanBay()
        {
            InitializeComponent();
            msb = txtMaSanBay.Text;
        }

        private void btn_LayDS_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = sbBus.LayDanhSach();
            grvSanBay.DataSource = bang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_ThemSanBay mh = new MH_ThemSanBay();
            mh.Show();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            msb = txtMaSanBay.Text;
            if (string.IsNullOrEmpty(msb))
            {
                MessageBox.Show("Vui lòng nhập mã sân bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            var rs = sbBus.XoaSanBay(msb);
            if (rs > 0)
            {
                MessageBox.Show("Xóa sân bay thành công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mtb = txtMaSanBay.Text;

            if (string.IsNullOrEmpty(mtb))
            {
                MessageBox.Show("Vui lòng nhập mã sân bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            MH_SuaSanBay mh = new MH_SuaSanBay();
            mh.MaSanBay = msb; // Gán giá trị mã sân bay vào thuộc tính MaTuyenBay
            mh.ShowDialog();
        }
    }
}
