namespace QuanLyChuyenBay.GUI
{
    partial class MH_ThemTuyenBay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_ThemTuyenBay = new Button();
            btn_Thoat = new Button();
            cbSanBayDen = new ComboBox();
            cbSanBayDi = new ComboBox();
            txtMaTuyenBay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Thêm Tuyến Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 63);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Tuyến Bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 103);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Sân Bây Đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 144);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Sân Bay Đến";
            // 
            // btn_ThemTuyenBay
            // 
            btn_ThemTuyenBay.Location = new Point(152, 197);
            btn_ThemTuyenBay.Name = "btn_ThemTuyenBay";
            btn_ThemTuyenBay.Size = new Size(75, 23);
            btn_ThemTuyenBay.TabIndex = 4;
            btn_ThemTuyenBay.Text = "Thêm";
            btn_ThemTuyenBay.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(263, 197);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // cbSanBayDen
            // 
            cbSanBayDen.FormattingEnabled = true;
            cbSanBayDen.Location = new Point(152, 136);
            cbSanBayDen.Name = "cbSanBayDen";
            cbSanBayDen.Size = new Size(186, 23);
            cbSanBayDen.TabIndex = 6;
            // 
            // cbSanBayDi
            // 
            cbSanBayDi.FormattingEnabled = true;
            cbSanBayDi.Location = new Point(152, 100);
            cbSanBayDi.Name = "cbSanBayDi";
            cbSanBayDi.Size = new Size(186, 23);
            cbSanBayDi.TabIndex = 7;
            // 
            // txtMaTuyenBay
            // 
            txtMaTuyenBay.Enabled = false;
            txtMaTuyenBay.Location = new Point(152, 60);
            txtMaTuyenBay.Name = "txtMaTuyenBay";
            txtMaTuyenBay.Size = new Size(186, 23);
            txtMaTuyenBay.TabIndex = 8;
            // 
            // MH_ThemTuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 239);
            Controls.Add(txtMaTuyenBay);
            Controls.Add(cbSanBayDi);
            Controls.Add(cbSanBayDen);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_ThemTuyenBay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_ThemTuyenBay";
            Text = "Thêm Tuyến Bay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_ThemTuyenBay;
        private Button btn_Thoat;
        private ComboBox cbSanBayDen;
        private ComboBox cbSanBayDi;
        internal TextBox txtMaTuyenBay;
    }
}