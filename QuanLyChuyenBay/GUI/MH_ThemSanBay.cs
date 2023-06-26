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
    public partial class MH_ThemSanBay : Form
    {        
        public MH_ThemSanBay()
        {
            InitializeComponent();
        }
        private void btn_LuuSanBay_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            SanBayBUS sbBus = new SanBayBUS();
            sb.TenSanBay = txtTenSanBay.Text;
            sb.MaSanBay = txtMaSanBay.Text;
            var rs = sbBus.ThemSanBay(sb);
            if (rs == -1)
            {
                MessageBox.Show("Chưa nhập mã sân bay !!!");
                return;
            }

            if (rs == -2)
            {
                MessageBox.Show("Chưa nhập tên sân bay !!!");
                return;
            }
            else if (rs > 0)
            {
                sbBus.LayDSSanBay();
                MessageBox.Show("Thêm thành công!");
            }
        }
        private void btn_ThemSanBay_Click(object sender, EventArgs e)
        {
            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void btn_ThoatSanBay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MH_ThemSanBay_Load(object sender, EventArgs e)
        {

        }
    }
}
