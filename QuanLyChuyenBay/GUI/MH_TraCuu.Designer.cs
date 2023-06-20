namespace QuanLyChuyenBay
{
    partial class MH_TraCuu
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
            grvChuyenBay = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbSanBayDi = new ComboBox();
            label1 = new Label();
            cbSanBayDen = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dtpTu = new DateTimePicker();
            dtpDen = new DateTimePicker();
            btn_Tim = new Button();
            btn_Thoat = new Button();
            lbTenSBDen = new Label();
            lbTenSBDi = new Label();
            ((System.ComponentModel.ISupportInitialize)grvChuyenBay).BeginInit();
            SuspendLayout();
            // 
            // grvChuyenBay
            // 
            grvChuyenBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvChuyenBay.Location = new Point(12, 240);
            grvChuyenBay.Name = "grvChuyenBay";
            grvChuyenBay.RowTemplate.Height = 25;
            grvChuyenBay.Size = new Size(670, 166);
            grvChuyenBay.TabIndex = 0;
            grvChuyenBay.CellContentClick += grvChuyenBay_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 71);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Sân Bay Đi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Sân Bay Đến";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày Khởi Hành";
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(178, 68);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(211, 23);
            cbSanBayDi.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 7;
            label1.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(178, 99);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(211, 23);
            cbSanBayDen.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 149);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 11;
            label5.Text = "Từ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 149);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 12;
            label6.Text = "Đến";
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(178, 143);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(200, 23);
            dtpTu.TabIndex = 13;
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(455, 143);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(200, 23);
            dtpDen.TabIndex = 14;
            // 
            // btn_Tim
            // 
            btn_Tim.Location = new Point(50, 192);
            btn_Tim.Name = "btn_Tim";
            btn_Tim.Size = new Size(75, 23);
            btn_Tim.TabIndex = 15;
            btn_Tim.Text = "Tìm ";
            btn_Tim.UseVisualStyleBackColor = true;
            btn_Tim.Click += btn_Tim_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(178, 192);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 16;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
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
            // MH_TraCuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 418);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Tim);
            Controls.Add(dtpDen);
            Controls.Add(dtpTu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbSanBayDen);
            Controls.Add(label1);
            Controls.Add(cbSanBayDi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grvChuyenBay);
            Name = "MH_TraCuu";
            Text = "Tra Cứu Chuyến Bay";
            Load += MH_TraCuu_Load;
            ((System.ComponentModel.ISupportInitialize)grvChuyenBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grvChuyenBay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbSanBayDi;
        private ComboBox cbSanBayDen;
        private DateTimePicker dtpTu;
        private DateTimePicker dtpDen;
        private Button btn_Tim;
        private Button btn_Thoat;
        private Label lbTenSBDi;
        private Label lbTenSBDen;
    }
}