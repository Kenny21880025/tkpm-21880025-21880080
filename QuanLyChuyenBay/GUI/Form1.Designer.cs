namespace QuanLyChuyenBay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NhanLich = new System.Windows.Forms.Button();
            this.btn_BanVe = new System.Windows.Forms.Button();
            this.btn_DatCho = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doanhThuThang = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuNam = new System.Windows.Forms.ToolStripMenuItem();
            this.QD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.QD3 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grvLichBay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichBay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NhanLich
            // 
            this.btn_NhanLich.Location = new System.Drawing.Point(49, 72);
            this.btn_NhanLich.Name = "btn_NhanLich";
            this.btn_NhanLich.Size = new System.Drawing.Size(107, 66);
            this.btn_NhanLich.TabIndex = 0;
            this.btn_NhanLich.Text = "Nhận Lịch Chuyến Bay";
            this.btn_NhanLich.UseVisualStyleBackColor = true;
            this.btn_NhanLich.Click += new System.EventHandler(this.btn_NhanLich_Click_1);
            // 
            // btn_BanVe
            // 
            this.btn_BanVe.Location = new System.Drawing.Point(242, 72);
            this.btn_BanVe.Name = "btn_BanVe";
            this.btn_BanVe.Size = new System.Drawing.Size(107, 66);
            this.btn_BanVe.TabIndex = 1;
            this.btn_BanVe.Text = "Bán Vé Chuyến Bay";
            this.btn_BanVe.UseVisualStyleBackColor = true;
            // 
            // btn_DatCho
            // 
            this.btn_DatCho.Location = new System.Drawing.Point(444, 72);
            this.btn_DatCho.Name = "btn_DatCho";
            this.btn_DatCho.Size = new System.Drawing.Size(107, 66);
            this.btn_DatCho.TabIndex = 2;
            this.btn_DatCho.Text = "Phiếu Đặt Chỗ";
            this.btn_DatCho.UseVisualStyleBackColor = true;
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Location = new System.Drawing.Point(639, 72);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(107, 66);
            this.btn_TraCuu.TabIndex = 3;
            this.btn_TraCuu.Text = "Tra Cứu Chuyến Bay";
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuThang,
            this.doanhThuNam,
            this.QD1,
            this.QD2,
            this.QD3,
            this.đăngKýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doanhThuThang
            // 
            this.doanhThuThang.Name = "doanhThuThang";
            this.doanhThuThang.Size = new System.Drawing.Size(160, 20);
            this.doanhThuThang.Text = "Báo Cáo Doanh Thu Tháng";
            // 
            // doanhThuNam
            // 
            this.doanhThuNam.Name = "doanhThuNam";
            this.doanhThuNam.Size = new System.Drawing.Size(153, 20);
            this.doanhThuNam.Text = "Báo Cáo Doanh Thu Năm";
            // 
            // QD1
            // 
            this.QD1.Name = "QD1";
            this.QD1.Size = new System.Drawing.Size(78, 20);
            this.QD1.Text = "Quy Định 1";
            // 
            // QD2
            // 
            this.QD2.Name = "QD2";
            this.QD2.Size = new System.Drawing.Size(78, 20);
            this.QD2.Text = "Quy Định 2";
            // 
            // QD3
            // 
            this.QD3.Name = "QD3";
            this.QD3.Size = new System.Drawing.Size(78, 20);
            this.QD3.Text = "Quy Định 3";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.đăngKýToolStripMenuItem.Text = "Thoát";
            // 
            // grvLichBay
            // 
            this.grvLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLichBay.Location = new System.Drawing.Point(49, 171);
            this.grvLichBay.Name = "grvLichBay";
            this.grvLichBay.RowTemplate.Height = 25;
            this.grvLichBay.Size = new System.Drawing.Size(697, 248);
            this.grvLichBay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "SVTH: Trần Quốc Dũng - 21880025 và Trần Phan Quang Minh - 21880080";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvLichBay);
            this.Controls.Add(this.btn_TraCuu);
            this.Controls.Add(this.btn_DatCho);
            this.Controls.Add(this.btn_BanVe);
            this.Controls.Add(this.btn_NhanLich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Chuyến Bay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_NhanLich;
        private Button btn_BanVe;
        private Button btn_DatCho;
        private Button btn_TraCuu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem doanhThuThang;
        private ToolStripMenuItem doanhThuNam;
        private DataGridView grvLichBay;
        private Label label1;
        private ToolStripMenuItem QD1;
        private ToolStripMenuItem QD2;
        private ToolStripMenuItem QD3;
        private ToolStripMenuItem đăngKýToolStripMenuItem;
    }
}