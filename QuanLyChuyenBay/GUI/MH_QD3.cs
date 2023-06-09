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
        public MH_QD3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qd3.TimeOrder = int.Parse(txtTimeOrder.Text);
            qd3.TimeCancel =int.Parse(txtTimeCancel.Text);
            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tsDb.SuaQD3(qd3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MH_QD3_Load(object sender, EventArgs e)
        {

        }
    }
}
