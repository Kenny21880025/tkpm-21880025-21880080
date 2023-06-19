namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaChuyenBay
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
            dtpNgayGio = new DateTimePicker();
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            label3 = new Label();
            txtMaChuyenBay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Sửa Thông Tin Chuyến Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 105);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Sửa Ngày Giờ Bay";
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(154, 99);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(200, 23);
            dtpNgayGio.TabIndex = 2;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(93, 137);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 3;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(223, 137);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 48);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Mã Chuyến Bay";
            // 
            // txtMaChuyenBay
            // 
            txtMaChuyenBay.Location = new Point(154, 45);
            txtMaChuyenBay.Name = "txtMaChuyenBay";
            txtMaChuyenBay.Size = new Size(200, 23);
            txtMaChuyenBay.TabIndex = 6;
            // 
            // MH_SuaChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 179);
            Controls.Add(txtMaChuyenBay);
            Controls.Add(label3);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(dtpNgayGio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_SuaChuyenBay";
            Text = "MH_SuaChuyenBay";
            Load += MH_SuaChuyenBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpNgayGio;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private Label label3;
        private TextBox txtMaChuyenBay;
    }
}