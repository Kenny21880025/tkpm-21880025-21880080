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
            btn_NhanLich = new Button();
            btn_BanVe = new Button();
            btn_DatCho = new Button();
            btn_TraCuu = new Button();
            menuStrip1 = new MenuStrip();
            menuXinChao = new ToolStripMenuItem();
            doanhThuThang = new ToolStripMenuItem();
            doanhThuNam = new ToolStripMenuItem();
            QD1 = new ToolStripMenuItem();
            QD2 = new ToolStripMenuItem();
            QD3 = new ToolStripMenuItem();
            đăngKýToolStripMenuItem = new ToolStripMenuItem();
            grvLichBay = new DataGridView();
            label1 = new Label();
            lblTenDangNhap = new Label();
            btn_LayDanhSachChuyenBay = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvLichBay).BeginInit();
            SuspendLayout();
            // 
            // btn_NhanLich
            // 
            btn_NhanLich.Location = new Point(192, 72);
            btn_NhanLich.Name = "btn_NhanLich";
            btn_NhanLich.Size = new Size(107, 66);
            btn_NhanLich.TabIndex = 0;
            btn_NhanLich.Text = "Nhận Lịch Chuyến Bay";
            btn_NhanLich.UseVisualStyleBackColor = true;
            btn_NhanLich.Click += btn_NhanLich_Click;
            // 
            // btn_BanVe
            // 
            btn_BanVe.Location = new Point(340, 72);
            btn_BanVe.Name = "btn_BanVe";
            btn_BanVe.Size = new Size(107, 66);
            btn_BanVe.TabIndex = 1;
            btn_BanVe.Text = "Bán Vé Chuyến Bay";
            btn_BanVe.UseVisualStyleBackColor = true;
            btn_BanVe.Click += btn_BanVe_Click;
            // 
            // btn_DatCho
            // 
            btn_DatCho.Location = new Point(489, 72);
            btn_DatCho.Name = "btn_DatCho";
            btn_DatCho.Size = new Size(107, 66);
            btn_DatCho.TabIndex = 2;
            btn_DatCho.Text = "Phiếu Đặt Chỗ";
            btn_DatCho.UseVisualStyleBackColor = true;
            btn_DatCho.Click += btn_DatCho_Click;
            // 
            // btn_TraCuu
            // 
            btn_TraCuu.Location = new Point(639, 72);
            btn_TraCuu.Name = "btn_TraCuu";
            btn_TraCuu.Size = new Size(107, 66);
            btn_TraCuu.TabIndex = 3;
            btn_TraCuu.Text = "Tra Cứu Chuyến Bay";
            btn_TraCuu.UseVisualStyleBackColor = true;
            btn_TraCuu.Click += btn_TraCuu_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuXinChao, doanhThuThang, doanhThuNam, QD1, QD2, QD3, đăngKýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuXinChao
            // 
            menuXinChao.Name = "menuXinChao";
            menuXinChao.Size = new Size(65, 20);
            menuXinChao.Text = "Xin chào";
            menuXinChao.Click += menuXinChao_Click;
            // 
            // doanhThuThang
            // 
            doanhThuThang.Name = "doanhThuThang";
            doanhThuThang.Size = new Size(160, 20);
            doanhThuThang.Text = "Báo Cáo Doanh Thu Tháng";
            // 
            // doanhThuNam
            // 
            doanhThuNam.Name = "doanhThuNam";
            doanhThuNam.Size = new Size(153, 20);
            doanhThuNam.Text = "Báo Cáo Doanh Thu Năm";
            // 
            // QD1
            // 
            QD1.Name = "QD1";
            QD1.Size = new Size(78, 20);
            QD1.Text = "Quy Định 1";
            // 
            // QD2
            // 
            QD2.Name = "QD2";
            QD2.Size = new Size(78, 20);
            QD2.Text = "Quy Định 2";
            // 
            // QD3
            // 
            QD3.Name = "QD3";
            QD3.Size = new Size(78, 20);
            QD3.Text = "Quy Định 3";
            // 
            // đăngKýToolStripMenuItem
            // 
            đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            đăngKýToolStripMenuItem.Size = new Size(49, 20);
            đăngKýToolStripMenuItem.Text = "Thoát";
            đăngKýToolStripMenuItem.Click += đăngKýToolStripMenuItem_Click;
            // 
            // grvLichBay
            // 
            grvLichBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvLichBay.Location = new Point(49, 171);
            grvLichBay.Name = "grvLichBay";
            grvLichBay.RowTemplate.Height = 25;
            grvLichBay.Size = new Size(697, 241);
            grvLichBay.TabIndex = 5;
            grvLichBay.CellContentClick += grvLichBay_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(192, 426);
            label1.Name = "label1";
            label1.Size = new Size(385, 15);
            label1.TabIndex = 6;
            label1.Text = "SVTH: Trần Quốc Dũng - 21880025 và Trần Phan Quang Minh - 21880080";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Location = new Point(0, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(100, 23);
            lblTenDangNhap.TabIndex = 0;
            // 
            // btn_LayDanhSachChuyenBay
            // 
            btn_LayDanhSachChuyenBay.Location = new Point(49, 72);
            btn_LayDanhSachChuyenBay.Name = "btn_LayDanhSachChuyenBay";
            btn_LayDanhSachChuyenBay.Size = new Size(102, 66);
            btn_LayDanhSachChuyenBay.TabIndex = 7;
            btn_LayDanhSachChuyenBay.Text = "Lấy Danh Sách Chuyến Bay";
            btn_LayDanhSachChuyenBay.UseVisualStyleBackColor = true;
            btn_LayDanhSachChuyenBay.Click += btn_LayDanhSachChuyenBay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_LayDanhSachChuyenBay);
            Controls.Add(label1);
            Controls.Add(grvLichBay);
            Controls.Add(btn_TraCuu);
            Controls.Add(btn_DatCho);
            Controls.Add(btn_BanVe);
            Controls.Add(btn_NhanLich);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Chuyến Bay";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grvLichBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTenDangNhap;
        private ToolStripMenuItem QD1;
        private ToolStripMenuItem QD2;
        private ToolStripMenuItem QD3;
        private ToolStripMenuItem đăngKýToolStripMenuItem;
        private Button btn_LayDanhSachChuyenBay;
        private ToolStripMenuItem menuXinChao;
    }
}