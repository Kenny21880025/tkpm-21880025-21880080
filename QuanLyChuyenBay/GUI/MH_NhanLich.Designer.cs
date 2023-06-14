namespace QuanLyChuyenBay
{
    partial class MH_NhanLich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_NhanLich = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbTenSBDen = new Label();
            lbTenSBDi = new Label();
            grvSanBayTrungGian = new DataGridView();
            txtMaChuyenBay = new TextBox();
            txtThoiGianBay = new TextBox();
            txtGheHang1 = new TextBox();
            txtGheHang2 = new TextBox();
            btn_LuuLichBay = new Button();
            btn_ThemLichBay = new Button();
            btn_ThoatLichBay = new Button();
            dtpNgayGio = new DateTimePicker();
            cbSanBayDi = new ComboBox();
            cbSanBayDen = new ComboBox();
            btn_SanBayDi = new Button();
            btn_SanBayDen = new Button();
            ((System.ComponentModel.ISupportInitialize)grvSanBayTrungGian).BeginInit();
            SuspendLayout();
            // 
            // lb_NhanLich
            // 
            lb_NhanLich.AutoSize = true;
            lb_NhanLich.Location = new Point(107, 20);
            lb_NhanLich.Name = "lb_NhanLich";
            lb_NhanLich.Size = new Size(127, 15);
            lb_NhanLich.TabIndex = 0;
            lb_NhanLich.Text = "Nhận Lịch Chuyến Bay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã Chuyến Bay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Ngày Giờ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 202);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Thời Gian Bay";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 242);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 11;
            label6.Text = "Số Lượng Ghế Hạng 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 277);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 12;
            label7.Text = "Số Lượng Ghế Hạng 2";
            // 
            // lbTenSBDen
            // 
            lbTenSBDen.Location = new Point(0, 0);
            lbTenSBDen.Name = "lbTenSBDen";
            lbTenSBDen.Size = new Size(100, 23);
            lbTenSBDen.TabIndex = 0;
            // 
            // lbTenSBDi
            // 
            lbTenSBDi.Location = new Point(0, 0);
            lbTenSBDi.Name = "lbTenSBDi";
            lbTenSBDi.Size = new Size(100, 23);
            lbTenSBDi.TabIndex = 0;
            // 
            // grvSanBayTrungGian
            // 
            grvSanBayTrungGian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvSanBayTrungGian.Location = new Point(12, 307);
            grvSanBayTrungGian.Name = "grvSanBayTrungGian";
            grvSanBayTrungGian.RowTemplate.Height = 25;
            grvSanBayTrungGian.Size = new Size(371, 95);
            grvSanBayTrungGian.TabIndex = 13;
            grvSanBayTrungGian.CellContentClick += grvSanBayTrungGian_CellContentClick;
            // 
            // txtMaChuyenBay
            // 
            txtMaChuyenBay.Location = new Point(191, 44);
            txtMaChuyenBay.Name = "txtMaChuyenBay";
            txtMaChuyenBay.Size = new Size(192, 23);
            txtMaChuyenBay.TabIndex = 14;
            // 
            // txtThoiGianBay
            // 
            txtThoiGianBay.Location = new Point(191, 198);
            txtThoiGianBay.Name = "txtThoiGianBay";
            txtThoiGianBay.Size = new Size(192, 23);
            txtThoiGianBay.TabIndex = 18;
            // 
            // txtGheHang1
            // 
            txtGheHang1.Location = new Point(191, 234);
            txtGheHang1.Name = "txtGheHang1";
            txtGheHang1.Size = new Size(192, 23);
            txtGheHang1.TabIndex = 19;
            // 
            // txtGheHang2
            // 
            txtGheHang2.Location = new Point(191, 269);
            txtGheHang2.Name = "txtGheHang2";
            txtGheHang2.Size = new Size(192, 23);
            txtGheHang2.TabIndex = 20;
            // 
            // btn_LuuLichBay
            // 
            btn_LuuLichBay.Location = new Point(27, 415);
            btn_LuuLichBay.Name = "btn_LuuLichBay";
            btn_LuuLichBay.Size = new Size(75, 23);
            btn_LuuLichBay.TabIndex = 21;
            btn_LuuLichBay.Text = "Lưu";
            btn_LuuLichBay.UseVisualStyleBackColor = true;
            btn_LuuLichBay.Click += btn_LuuLichBay_Click;
            // 
            // btn_ThemLichBay
            // 
            btn_ThemLichBay.Location = new Point(159, 415);
            btn_ThemLichBay.Name = "btn_ThemLichBay";
            btn_ThemLichBay.Size = new Size(75, 23);
            btn_ThemLichBay.TabIndex = 22;
            btn_ThemLichBay.Text = "Thêm mới";
            btn_ThemLichBay.UseVisualStyleBackColor = true;
            btn_ThemLichBay.Click += btn_ThemLichBay_Click;
            // 
            // btn_ThoatLichBay
            // 
            btn_ThoatLichBay.Location = new Point(281, 415);
            btn_ThoatLichBay.Name = "btn_ThoatLichBay";
            btn_ThoatLichBay.Size = new Size(75, 23);
            btn_ThoatLichBay.TabIndex = 23;
            btn_ThoatLichBay.Text = "Thoát";
            btn_ThoatLichBay.UseVisualStyleBackColor = true;
            btn_ThoatLichBay.Click += btn_ThoatLichBay_Click;
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(191, 161);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(192, 23);
            dtpNgayGio.TabIndex = 24;
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(191, 88);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(192, 23);
            cbSanBayDi.TabIndex = 25;
            cbSanBayDi.SelectedIndexChanged += cbSanBayDi_SelectedIndexChanged;
            cbSanBayDi.Leave += cbSanBayDi_SelectedIndexChanged;
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(191, 125);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(192, 23);
            cbSanBayDen.TabIndex = 26;
            cbSanBayDen.SelectedIndexChanged += cbSanBayDen_SelectedIndexChanged;
            // 
            // btn_SanBayDi
            // 
            btn_SanBayDi.Location = new Point(16, 88);
            btn_SanBayDi.Name = "btn_SanBayDi";
            btn_SanBayDi.Size = new Size(86, 23);
            btn_SanBayDi.TabIndex = 27;
            btn_SanBayDi.Text = "Sân Bay Đi";
            btn_SanBayDi.UseVisualStyleBackColor = true;
            btn_SanBayDi.Click += btn_SanBayDi_Click;
            // 
            // btn_SanBayDen
            // 
            btn_SanBayDen.Location = new Point(16, 125);
            btn_SanBayDen.Name = "btn_SanBayDen";
            btn_SanBayDen.Size = new Size(86, 23);
            btn_SanBayDen.TabIndex = 28;
            btn_SanBayDen.Text = "Sân Bay Đến";
            btn_SanBayDen.UseVisualStyleBackColor = true;
            btn_SanBayDen.Click += btn_SanBayDen_Click;
            // 
            // MH_NhanLich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(395, 463);
            Controls.Add(btn_SanBayDen);
            Controls.Add(btn_SanBayDi);
            Controls.Add(cbSanBayDen);
            Controls.Add(cbSanBayDi);
            Controls.Add(dtpNgayGio);
            Controls.Add(btn_ThoatLichBay);
            Controls.Add(btn_ThemLichBay);
            Controls.Add(btn_LuuLichBay);
            Controls.Add(txtGheHang2);
            Controls.Add(txtGheHang1);
            Controls.Add(txtThoiGianBay);
            Controls.Add(txtMaChuyenBay);
            Controls.Add(grvSanBayTrungGian);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lb_NhanLich);
            Name = "MH_NhanLich";
            Text = "Nhận Lịch Chuyến Bay";
            Load += MH_NhanLich_Load;
            ((System.ComponentModel.ISupportInitialize)grvSanBayTrungGian).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_NhanLich;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbTenSBDi;
        private Label lbTenSBDen;
        private DataGridView grvSanBayTrungGian;
        private TextBox txtMaChuyenBay;
        private TextBox txtThoiGianBay;
        private TextBox txtGheHang1;
        private TextBox txtGheHang2;
        private Button btn_LuuLichBay;
        private Button btn_ThemLichBay;
        private Button btn_ThoatLichBay;
        private DateTimePicker dtpNgayGio;
        private ComboBox cbSanBayDi;
        private ComboBox cbSanBayDen;
        private Button btn_SanBayDi;
        private Button btn_SanBayDen;
    }
}