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
        DataTable ds = new DataTable();
        public MH_QD1()
        {
            InitializeComponent();
        }

        private void MH_QD1_Load(object sender, EventArgs e)
        {
            ds = tsDb.LayQD1();
            txtflymin.Text = ds.Rows[0][0].ToString();
            txtMiddleTerminal.Text = ds.Rows[0][1].ToString();
            txttimestopmax.Text = ds.Rows[0][2].ToString();
            txttimestopmin.Text = ds.Rows[0][3].ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int thoiGianBayToiThieu;
            int thoiGianDungToiDa;
            int soSanByTrungGianToiDa;
            int thoiGianDungToiThieu;

            if (!int.TryParse(txtflymin.Text, out thoiGianBayToiThieu))
            {
                MessageBox.Show("Xin nhập giá trị hợp lệ cho Thời gian bay tối thiểu.");
                return;
            }

            if (!int.TryParse(txttimestopmax.Text, out thoiGianDungToiDa))
            {
                MessageBox.Show("Xin nhập giá trị hợp lệ cho Thời gian dừng tối đa.");
                return;
            }

            if (!int.TryParse(txtMiddleTerminal.Text, out soSanByTrungGianToiDa))
            {
                MessageBox.Show("Xin nhập giá trị hợp lệ cho Số sân bay trung gian tối đa.");
                return;
            }

            if (!int.TryParse(txttimestopmin.Text, out thoiGianDungToiThieu))
            {
                MessageBox.Show("Xin nhập giá trị hợp lệ cho Thời gian dừng tối thiểu.");
                return;
            }

            if (MessageBox.Show("Bạn muốn cập nhật lại các giá trị này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                qd1.ThoiGianBayToiThieu = thoiGianBayToiThieu;
                qd1.ThoiGianDungToiDa = thoiGianDungToiDa;
                qd1.SoSanBayTrungGianToiDa = soSanByTrungGianToiDa;
                qd1.ThoiGianDungToiThieu = thoiGianDungToiThieu;
                var rs = tsDb.SuaQD1(qd1);
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
