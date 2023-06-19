using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class MH_BaoCaoThang : Form
    {
        public MH_BaoCaoThang()
        {
            InitializeComponent();
        }

        private void MH_BaoCaoThang_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }
            cbThang.Text = DateTime.Now.Month.ToString();
            int j;
            for (j = 1990; j <= DateTime.Now.Year; j++)
            {
                cbNam.Items.Add(j);
            }
            cbNam.Text = DateTime.Now.Year.ToString();

        }
        private void btn_BaoCao_Click(object sender, EventArgs e)
        {

        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
