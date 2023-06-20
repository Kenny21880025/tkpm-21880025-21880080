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
    public partial class MH_QD3 : Form
    {
        ThamSoDAO tsDb = new ThamSoDAO();
        QD3 qd3 = new QD3();
        DataTable ds = new DataTable();
        public MH_QD3()
        {
            InitializeComponent();
        }
        private void MH_QD3_Load(object sender, EventArgs e)
        {
            ds = tsDb.LayQD3();
            txtTimeOrder.Text = ds.Rows[0][0].ToString();
            txtTimeCancel.Text = ds.Rows[0][1].ToString();
            
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            qd3.TimeOrder = int.Parse(txtTimeOrder.Text);
            qd3.TimeCancel = int.Parse(txtTimeCancel.Text);
            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var rs = tsDb.SuaQD3(qd3);
                if (rs > 0)
                {
                    MessageBox.Show("Sửa quy định 1 thành công!!!");
                }
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
