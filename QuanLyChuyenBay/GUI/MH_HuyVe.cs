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
    public partial class MH_HuyVe : Form
    {
        VeChuyenBayBUS vcbBus = new VeChuyenBayBUS();
        PhieuDatChoBUS pdcBus = new PhieuDatChoBUS();
        string mv;
        public MH_HuyVe()
        {
            InitializeComponent();
        }
        private void btn_LayDS_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = vcbBus.LayDS();
            grvSanBay.DataSource = bang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_BanVe mh = new MH_BanVe();
            mh.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            mv = txtMaVe.Text;
            if (string.IsNullOrEmpty(mv))
            {
                MessageBox.Show("Vui lòng nhập mã vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }

            var rs = vcbBus.XoaVe(mv);
            if (rs > 0)
            {
                MessageBox.Show("Xóa vé thành công");
            }
        }  
    }
}
