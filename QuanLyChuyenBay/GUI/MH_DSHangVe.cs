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
    public partial class MH_DSHangVe : Form
    {
        HangVeBUS hvBus = new HangVeBUS();
        string mhv;
        public MH_DSHangVe()
        {
            InitializeComponent();
            mhv = txtMaHangVe.Text;
        }

        private void btn_LayDS_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }
        private void LayDuLieu()
        {
            var bang = hvBus.LayDanhSach();
            grvHangVe.DataSource = bang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MH_ThemHangVe mh = new MH_ThemHangVe();
            mh.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mhv))
            {
                MessageBox.Show("Vui lòng nhập mã hạng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }
            //mhv = txtMaHangVe.Text;
            var rs = hvBus.XoaHangVe(mhv);
            if (rs > 0)
            {
                MessageBox.Show("Xóa xóa bay thành công");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            mhv = txtMaHangVe.Text;
            if (string.IsNullOrEmpty(mhv))
            {
                MessageBox.Show("Vui lòng nhập mã hạng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện tiếp các câu lệnh bên dưới
            }
            MH_SuaHangVe mh = new MH_SuaHangVe();
            mh.MaHangVe = txtMaHangVe.Text;
            mh.Show();
        }       
    }
}
