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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_NhanLich = new Button();
            btn_BanVe = new Button();
            btn_DatCho = new Button();
            btn_TraCuu = new Button();
            menuStrip1 = new MenuStrip();
            menuXinChao = new ToolStripMenuItem();
            khoDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            DS_TuyenBay = new ToolStripMenuItem();
            DS_SanBay = new ToolStripMenuItem();
            DS_HangVe = new ToolStripMenuItem();
            DS_KhachHang = new ToolStripMenuItem();
            báoCáoDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            DT_Thang = new ToolStripMenuItem();
            DT_Nam = new ToolStripMenuItem();
            quyĐịnhToolStripMenuItem = new ToolStripMenuItem();
            QD1 = new ToolStripMenuItem();
            QD2 = new ToolStripMenuItem();
            QD3 = new ToolStripMenuItem();
            Thoat = new ToolStripMenuItem();
            grvLichBay = new DataGridView();
            label1 = new Label();
            lblTenDangNhap = new Label();
            btn_LayDanhSachChuyenBay = new Button();
            panel1 = new Panel();
            DS_ChuyenBay = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvLichBay).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_NhanLich
            // 
            btn_NhanLich.BackColor = Color.Black;
            btn_NhanLich.FlatAppearance.BorderColor = Color.Black;
            btn_NhanLich.FlatAppearance.BorderSize = 0;
            btn_NhanLich.FlatStyle = FlatStyle.Flat;
            btn_NhanLich.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NhanLich.ForeColor = Color.White;
            btn_NhanLich.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhanLich.Location = new Point(3, 31);
            btn_NhanLich.Name = "btn_NhanLich";
            btn_NhanLich.Size = new Size(227, 66);
            btn_NhanLich.TabIndex = 0;
            btn_NhanLich.Text = "             Nhận Lịch Chuyến Bay";
            btn_NhanLich.TextAlign = ContentAlignment.MiddleLeft;
            btn_NhanLich.UseVisualStyleBackColor = false;
            btn_NhanLich.Click += btn_NhanLich_Click;
            // 
            // btn_BanVe
            // 
            btn_BanVe.BackColor = Color.Black;
            btn_BanVe.FlatStyle = FlatStyle.Popup;
            btn_BanVe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BanVe.ForeColor = Color.White;
            btn_BanVe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BanVe.Location = new Point(3, 151);
            btn_BanVe.Name = "btn_BanVe";
            btn_BanVe.Size = new Size(227, 66);
            btn_BanVe.TabIndex = 1;
            btn_BanVe.Text = "             Bán Vé Chuyến Bay";
            btn_BanVe.TextAlign = ContentAlignment.MiddleLeft;
            btn_BanVe.UseVisualStyleBackColor = false;
            btn_BanVe.Click += btn_BanVe_Click;
            // 
            // btn_DatCho
            // 
            btn_DatCho.BackColor = Color.Black;
            btn_DatCho.FlatStyle = FlatStyle.Popup;
            btn_DatCho.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DatCho.ForeColor = Color.White;
            btn_DatCho.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DatCho.Location = new Point(3, 214);
            btn_DatCho.Name = "btn_DatCho";
            btn_DatCho.Size = new Size(227, 66);
            btn_DatCho.TabIndex = 2;
            btn_DatCho.Text = "             Phiếu Đặt Chỗ";
            btn_DatCho.TextAlign = ContentAlignment.MiddleLeft;
            btn_DatCho.UseVisualStyleBackColor = false;
            btn_DatCho.Click += btn_DatCho_Click;
            // 
            // btn_TraCuu
            // 
            btn_TraCuu.BackColor = Color.Black;
            btn_TraCuu.FlatStyle = FlatStyle.Popup;
            btn_TraCuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TraCuu.ForeColor = Color.White;
            btn_TraCuu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TraCuu.Location = new Point(0, 275);
            btn_TraCuu.Name = "btn_TraCuu";
            btn_TraCuu.Size = new Size(227, 66);
            btn_TraCuu.TabIndex = 3;
            btn_TraCuu.Text = "             Tra Cứu Chuyến Bay";
            btn_TraCuu.TextAlign = ContentAlignment.MiddleLeft;
            btn_TraCuu.UseVisualStyleBackColor = false;
            btn_TraCuu.Click += btn_TraCuu_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuXinChao, khoDữLiệuToolStripMenuItem, báoCáoDoanhThuToolStripMenuItem, quyĐịnhToolStripMenuItem, Thoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuXinChao
            // 
            menuXinChao.ForeColor = Color.White;
            menuXinChao.Name = "menuXinChao";
            menuXinChao.Size = new Size(65, 20);
            menuXinChao.Text = "Xin chào";
            menuXinChao.Click += menuXinChao_Click;
            // 
            // khoDữLiệuToolStripMenuItem
            // 
            khoDữLiệuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DS_TuyenBay, DS_SanBay, DS_HangVe, DS_KhachHang, DS_ChuyenBay });
            khoDữLiệuToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            khoDữLiệuToolStripMenuItem.Name = "khoDữLiệuToolStripMenuItem";
            khoDữLiệuToolStripMenuItem.Size = new Size(83, 20);
            khoDữLiệuToolStripMenuItem.Text = "Kho Dữ Liệu";
            // 
            // DS_TuyenBay
            // 
            DS_TuyenBay.Name = "DS_TuyenBay";
            DS_TuyenBay.Size = new Size(198, 22);
            DS_TuyenBay.Text = "Danh Sách Tuyến Bay";
            DS_TuyenBay.Click += DS_TuyenBay_Click;
            // 
            // DS_SanBay
            // 
            DS_SanBay.Name = "DS_SanBay";
            DS_SanBay.Size = new Size(198, 22);
            DS_SanBay.Text = "Danh Sách Sân Bay";
            DS_SanBay.Click += DS_SanBay_Click;
            // 
            // DS_HangVe
            // 
            DS_HangVe.Name = "DS_HangVe";
            DS_HangVe.Size = new Size(198, 22);
            DS_HangVe.Text = "Danh Sách Hạng Vé";
            DS_HangVe.Click += DS_HangVe_Click;
            // 
            // DS_KhachHang
            // 
            DS_KhachHang.Name = "DS_KhachHang";
            DS_KhachHang.Size = new Size(198, 22);
            DS_KhachHang.Text = "Danh Sách Khách Hàng";
            DS_KhachHang.Click += DS_KhachHang_Click;
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            báoCáoDoanhThuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DT_Thang, DT_Nam });
            báoCáoDoanhThuToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            báoCáoDoanhThuToolStripMenuItem.Size = new Size(124, 20);
            báoCáoDoanhThuToolStripMenuItem.Text = "Báo Cáo Doanh Thu";
            // 
            // DT_Thang
            // 
            DT_Thang.Name = "DT_Thang";
            DT_Thang.Size = new Size(168, 22);
            DT_Thang.Text = "Doanh Thu Tháng";
            DT_Thang.Click += DT_Thang_Click;
            // 
            // DT_Nam
            // 
            DT_Nam.Name = "DT_Nam";
            DT_Nam.Size = new Size(168, 22);
            DT_Nam.Text = "Doanh Thu Năm";
            DT_Nam.Click += DT_Nam_Click;
            // 
            // quyĐịnhToolStripMenuItem
            // 
            quyĐịnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QD1, QD2, QD3 });
            quyĐịnhToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            quyĐịnhToolStripMenuItem.Name = "quyĐịnhToolStripMenuItem";
            quyĐịnhToolStripMenuItem.Size = new Size(69, 20);
            quyĐịnhToolStripMenuItem.Text = "Quy Định";
            // 
            // QD1
            // 
            QD1.Name = "QD1";
            QD1.Size = new Size(97, 22);
            QD1.Text = "QD1";
            QD1.Click += QD1_Click;
            // 
            // QD2
            // 
            QD2.Name = "QD2";
            QD2.Size = new Size(97, 22);
            QD2.Text = "QD2";
            QD2.Click += QD2_Click;
            // 
            // QD3
            // 
            QD3.Name = "QD3";
            QD3.Size = new Size(97, 22);
            QD3.Text = "QD3";
            QD3.Click += QD3_Click;
            // 
            // Thoat
            // 
            Thoat.ForeColor = Color.White;
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(49, 20);
            Thoat.Text = "Thoát";
            Thoat.Click += Thoat_Click;
            // 
            // grvLichBay
            // 
            grvLichBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvLichBay.Location = new Point(211, 30);
            grvLichBay.Name = "grvLichBay";
            grvLichBay.RowTemplate.Height = 25;
            grvLichBay.Size = new Size(577, 373);
            grvLichBay.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(317, 413);
            label1.Name = "label1";
            label1.Size = new Size(351, 15);
            label1.TabIndex = 6;
            label1.Text = "Trần Quốc Dũng - 21880025 và Trần Phan Quang Minh - 21880080";
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
            btn_LayDanhSachChuyenBay.BackColor = Color.Black;
            btn_LayDanhSachChuyenBay.FlatAppearance.BorderColor = Color.Black;
            btn_LayDanhSachChuyenBay.FlatAppearance.BorderSize = 0;
            btn_LayDanhSachChuyenBay.FlatStyle = FlatStyle.Flat;
            btn_LayDanhSachChuyenBay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LayDanhSachChuyenBay.ForeColor = Color.White;
            btn_LayDanhSachChuyenBay.Image = (Image)resources.GetObject("btn_LayDanhSachChuyenBay.Image");
            btn_LayDanhSachChuyenBay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LayDanhSachChuyenBay.Location = new Point(0, 91);
            btn_LayDanhSachChuyenBay.Name = "btn_LayDanhSachChuyenBay";
            btn_LayDanhSachChuyenBay.Size = new Size(227, 66);
            btn_LayDanhSachChuyenBay.TabIndex = 7;
            btn_LayDanhSachChuyenBay.Text = "             Danh Sách Chuyến Bay";
            btn_LayDanhSachChuyenBay.TextAlign = ContentAlignment.MiddleLeft;
            btn_LayDanhSachChuyenBay.UseVisualStyleBackColor = false;
            btn_LayDanhSachChuyenBay.Click += btn_LayDanhSachChuyenBay_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_NhanLich);
            panel1.Controls.Add(btn_LayDanhSachChuyenBay);
            panel1.Controls.Add(btn_BanVe);
            panel1.Controls.Add(btn_DatCho);
            panel1.Controls.Add(btn_TraCuu);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 425);
            panel1.TabIndex = 8;
            // 
            // DS_ChuyenBay
            // 
            DS_ChuyenBay.Name = "DS_ChuyenBay";
            DS_ChuyenBay.Size = new Size(198, 22);
            DS_ChuyenBay.Text = "Danh Sách Chuyến Bay";
            DS_ChuyenBay.Click += DS_ChuyenBay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(grvLichBay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Chuyến Bay";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grvLichBay).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_NhanLich;
        private Button btn_BanVe;
        private Button btn_DatCho;
        private Button btn_TraCuu;
        private MenuStrip menuStrip1;
        private DataGridView grvLichBay;
        private Label label1;
        private Label lblTenDangNhap;
        private ToolStripMenuItem Thoat;
        private Button btn_LayDanhSachChuyenBay;
        private ToolStripMenuItem menuXinChao;
        private Panel panel1;
        private ToolStripMenuItem khoDữLiệuToolStripMenuItem;
        private ToolStripMenuItem DS_TuyenBay;
        private ToolStripMenuItem DS_SanBay;
        private ToolStripMenuItem DS_HangVe;
        private ToolStripMenuItem DS_KhachHang;
        private ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private ToolStripMenuItem DT_Thang;
        private ToolStripMenuItem DT_Nam;
        private ToolStripMenuItem quyĐịnhToolStripMenuItem;
        private ToolStripMenuItem QD1;
        private ToolStripMenuItem QD2;
        private ToolStripMenuItem QD3;
        private ToolStripMenuItem DS_ChuyenBay;
    }
}