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
        public MH_QD2()
        {
            InitializeComponent();
        }

        private void MH_QD2_Load(object sender, EventArgs e)
        {
            //DataTable ds = tsDb.LayBangDonGia();
            //grvBangDonGiaVe.DataSource = ds;
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            qd2.SLHangVe = int.Parse(txtSoLuongHangGiaVe.Text);
            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tsDb.SuaQD2(qd2);
            }            
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
