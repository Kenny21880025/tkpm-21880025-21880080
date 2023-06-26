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
    public partial class MH_DSTuyenBay : Form
    {
        TuyenBayBUS tbBus = new TuyenBayBUS();
        string mtb;
        public MH_DSTuyenBay()
        {
            InitializeComponent();
            mtb = txtMaTuyenBay.Text;
        }
        private void btn_LayDS_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = tbBus.LayDSTuyenBay();
            grvTuyenBay.DataSource = bang;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_ThemTuyenBay mhttb = new MH_ThemTuyenBay();
            mhttb.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string mtb = txtMaTuyenBay.Text;
            if (string.IsNullOrEmpty(mtb))
            {
                MessageBox.Show("Vui lòng nhập mã tuyến bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            var rs = tbBus.XoaTuyenBay(mtb);
            if (rs > 0)
            {
                MessageBox.Show("Xóa tuyến bay thành công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mtb = txtMaTuyenBay.Text;

            if (string.IsNullOrEmpty(mtb))
            {
                MessageBox.Show("Vui lòng nhập mã tuyến bay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            MH_SuaTuyenBay mhstb = new MH_SuaTuyenBay();
            mhstb.MaTuyenBay = mtb; // Gán giá trị mã tuyến bay vào thuộc tính MaTuyenBay
            mhstb.ShowDialog();
        }
        
    }
}
