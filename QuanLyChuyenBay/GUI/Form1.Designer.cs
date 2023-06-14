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
            this.btn_NhanLich = new System.Windows.Forms.Button();
            this.btn_BanVe = new System.Windows.Forms.Button();
            this.btn_DatCho = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuXinChao = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuThang = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuNam = new System.Windows.Forms.ToolStripMenuItem();
            this.QD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.QD3 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grvLichBay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.btn_LayDanhSachChuyenBay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichBay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NhanLich
            // 
            this.btn_NhanLich.BackColor = System.Drawing.Color.Black;
            this.btn_NhanLich.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_NhanLich.FlatAppearance.BorderSize = 0;
            this.btn_NhanLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanLich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanLich.ForeColor = System.Drawing.Color.White;
            this.btn_NhanLich.Image = global::QuanLyChuyenBay.Properties.Resources.calendar_7_32;
            this.btn_NhanLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanLich.Location = new System.Drawing.Point(0, 111);
            this.btn_NhanLich.Name = "btn_NhanLich";
            this.btn_NhanLich.Size = new System.Drawing.Size(227, 66);
            this.btn_NhanLich.TabIndex = 0;
            this.btn_NhanLich.Text = "             Nhận Lịch Chuyến Bay";
            this.btn_NhanLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanLich.UseVisualStyleBackColor = false;
            // 
            // btn_BanVe
            // 
            this.btn_BanVe.BackColor = System.Drawing.Color.Black;
            this.btn_BanVe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BanVe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BanVe.ForeColor = System.Drawing.Color.White;
            this.btn_BanVe.Image = global::QuanLyChuyenBay.Properties.Resources.ticket_32;
            this.btn_BanVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanVe.Location = new System.Drawing.Point(0, 234);
            this.btn_BanVe.Name = "btn_BanVe";
            this.btn_BanVe.Size = new System.Drawing.Size(227, 66);
            this.btn_BanVe.TabIndex = 1;
            this.btn_BanVe.Text = "             Bán Vé Chuyến Bay";
            this.btn_BanVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanVe.UseVisualStyleBackColor = false;
            this.btn_BanVe.Click += new System.EventHandler(this.btn_BanVe_Click_1);
            // 
            // btn_DatCho
            // 
            this.btn_DatCho.BackColor = System.Drawing.Color.Black;
            this.btn_DatCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DatCho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DatCho.ForeColor = System.Drawing.Color.White;
            this.btn_DatCho.Image = global::QuanLyChuyenBay.Properties.Resources.appointment_reminders_32;
            this.btn_DatCho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DatCho.Location = new System.Drawing.Point(0, 297);
            this.btn_DatCho.Name = "btn_DatCho";
            this.btn_DatCho.Size = new System.Drawing.Size(227, 66);
            this.btn_DatCho.TabIndex = 2;
            this.btn_DatCho.Text = "             Phiếu Đặt Chỗ";
            this.btn_DatCho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DatCho.UseVisualStyleBackColor = false;
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.BackColor = System.Drawing.Color.Black;
            this.btn_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TraCuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TraCuu.ForeColor = System.Drawing.Color.White;
            this.btn_TraCuu.Image = global::QuanLyChuyenBay.Properties.Resources.search_9_32;
            this.btn_TraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuu.Location = new System.Drawing.Point(0, 359);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(227, 66);
            this.btn_TraCuu.TabIndex = 3;
            this.btn_TraCuu.Text = "             Tra Cứu Chuyến Bay";
            this.btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuu.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXinChao,
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
            // menuXinChao
            // 
            this.menuXinChao.ForeColor = System.Drawing.Color.White;
            this.menuXinChao.Name = "menuXinChao";
            this.menuXinChao.Size = new System.Drawing.Size(65, 20);
            this.menuXinChao.Text = "Xin chào";
            // 
            // doanhThuThang
            // 
            this.doanhThuThang.ForeColor = System.Drawing.Color.White;
            this.doanhThuThang.Name = "doanhThuThang";
            this.doanhThuThang.Size = new System.Drawing.Size(162, 20);
            this.doanhThuThang.Text = "Báo Cáo Doanh Thu Tháng";
            // 
            // doanhThuNam
            // 
            this.doanhThuNam.ForeColor = System.Drawing.Color.White;
            this.doanhThuNam.Name = "doanhThuNam";
            this.doanhThuNam.Size = new System.Drawing.Size(154, 20);
            this.doanhThuNam.Text = "Báo Cáo Doanh Thu Năm";
            // 
            // QD1
            // 
            this.QD1.ForeColor = System.Drawing.Color.White;
            this.QD1.Name = "QD1";
            this.QD1.Size = new System.Drawing.Size(78, 20);
            this.QD1.Text = "Quy Định 1";
            // 
            // QD2
            // 
            this.QD2.ForeColor = System.Drawing.Color.White;
            this.QD2.Name = "QD2";
            this.QD2.Size = new System.Drawing.Size(78, 20);
            this.QD2.Text = "Quy Định 2";
            // 
            // QD3
            // 
            this.QD3.ForeColor = System.Drawing.Color.White;
            this.QD3.Name = "QD3";
            this.QD3.Size = new System.Drawing.Size(78, 20);
            this.QD3.Text = "Quy Định 3";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.đăngKýToolStripMenuItem.Text = "Thoát";
            // 
            // grvLichBay
            // 
            this.grvLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLichBay.Location = new System.Drawing.Point(223, 27);
            this.grvLichBay.Name = "grvLichBay";
            this.grvLichBay.RowTemplate.Height = 25;
            this.grvLichBay.Size = new System.Drawing.Size(577, 373);
            this.grvLichBay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(317, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trần Quốc Dũng - 21880025 và Trần Phan Quang Minh - 21880080";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(100, 23);
            this.lblTenDangNhap.TabIndex = 0;
            // 
            // btn_LayDanhSachChuyenBay
            // 
            this.btn_LayDanhSachChuyenBay.BackColor = System.Drawing.Color.Black;
            this.btn_LayDanhSachChuyenBay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LayDanhSachChuyenBay.FlatAppearance.BorderSize = 0;
            this.btn_LayDanhSachChuyenBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LayDanhSachChuyenBay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LayDanhSachChuyenBay.ForeColor = System.Drawing.Color.White;
            this.btn_LayDanhSachChuyenBay.Image = ((System.Drawing.Image)(resources.GetObject("btn_LayDanhSachChuyenBay.Image")));
            this.btn_LayDanhSachChuyenBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LayDanhSachChuyenBay.Location = new System.Drawing.Point(0, 174);
            this.btn_LayDanhSachChuyenBay.Name = "btn_LayDanhSachChuyenBay";
            this.btn_LayDanhSachChuyenBay.Size = new System.Drawing.Size(227, 66);
            this.btn_LayDanhSachChuyenBay.TabIndex = 7;
            this.btn_LayDanhSachChuyenBay.Text = "             Danh Sách Chuyến Bay";
            this.btn_LayDanhSachChuyenBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LayDanhSachChuyenBay.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_NhanLich);
            this.panel1.Controls.Add(this.btn_LayDanhSachChuyenBay);
            this.panel1.Controls.Add(this.btn_BanVe);
            this.panel1.Controls.Add(this.btn_DatCho);
            this.panel1.Controls.Add(this.btn_TraCuu);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 425);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvLichBay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Chuyến Bay";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichBay)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Label lblTenDangNhap;
        private ToolStripMenuItem QD1;
        private ToolStripMenuItem QD2;
        private ToolStripMenuItem QD3;
        private ToolStripMenuItem đăngKýToolStripMenuItem;
        private Button btn_LayDanhSachChuyenBay;
        private ToolStripMenuItem menuXinChao;
        private Panel panel1;
    }
}