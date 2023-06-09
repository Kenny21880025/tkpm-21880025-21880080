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
    public partial class MH_QD1 : Form
    {
        ThamSoDAO tsDb = new ThamSoDAO();
        QD1 qd1 = new QD1();
        public MH_QD1()
        {
            InitializeComponent();
        }

        private void MH_QD1_Load(object sender, EventArgs e)
        {
            DataTable ds = tsDb.LayQD1();
            //txtflymin.Text = ds.Rows[0][0].ToString();
            //txtMiddleTerminal.Text = ds.Rows[0][1].ToString();
            //txttimestopmax.Text = ds.Rows[0][2].ToString();
            //txttimestopmin.Text = ds.Rows[0][3].ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            qd1.ThoiGianBayToiThieu = int.Parse(txtflymin.Text);
            qd1.ThoiGianDungToiDa = int.Parse(txttimestopmax.Text);
            qd1.SoSanByTrungGianToiDa = int.Parse(txtMiddleTerminal.Text);
            qd1.ThoiGianDungToiThieu = int.Parse(txttimestopmin.Text);
            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tsDb.SuaQD1(qd1);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
