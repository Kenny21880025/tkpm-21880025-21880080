using QuanLyChuyenBay.DAO;
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
    public partial class MH_QD2 : Form
    {
        ThamSoDAO tsDb = new ThamSoDAO();
        QD2 qd2 = new QD2();
        DataTable ds = new DataTable();
        DataTable SLHangVe = new DataTable();
        public MH_QD2()
        {
            InitializeComponent();
        }

        private void MH_QD2_Load(object sender, EventArgs e)
        {
            ds = tsDb.LayBangDonGia();
            SLHangVe = tsDb.LayQD2();
            grvBangDonGiaVe.DataSource = ds;
            txtSLHangVe.Text = SLHangVe.Rows[0][0].ToString();
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            qd2.SLHangVe = int.Parse(txtSLHangVe.Text);
            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var rs = tsDb.SuaQD2(qd2);
                if (rs > 0)
                {
                    MessageBox.Show("Sửa quy định 2 thành công!!!");
                }
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoLuongHangGiaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void grvBangDonGiaVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
