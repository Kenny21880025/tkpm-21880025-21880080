namespace QuanLyChuyenBay.GUI
{
    partial class MH_ThemHanhKhach
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
        public void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHanhKhach = new TextBox();
            txtTenHanhKhach = new TextBox();
            txtID = new TextBox();
            txtDienThoai = new TextBox();
            btn_Thoat = new Button();
            btn_ThemHanhKhach = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Hành Khách Mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 64);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Hành Khách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 100);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Hành Khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 138);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "CMND/CCCD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 171);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Điện Thoại";
            // 
            // txtMaHanhKhach
            // 
            txtMaHanhKhach.Location = new Point(139, 61);
            txtMaHanhKhach.Name = "txtMaHanhKhach";
            txtMaHanhKhach.Size = new Size(168, 23);
            txtMaHanhKhach.TabIndex = 5;
            // 
            // txtTenHanhKhach
            // 
            txtTenHanhKhach.Location = new Point(139, 97);
            txtTenHanhKhach.Name = "txtTenHanhKhach";
            txtTenHanhKhach.Size = new Size(168, 23);
            txtTenHanhKhach.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(139, 135);
            txtID.Name = "txtID";
            txtID.Size = new Size(168, 23);
            txtID.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(139, 168);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(168, 23);
            txtDienThoai.TabIndex = 8;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(232, 243);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 9;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_ThemHanhKhach
            // 
            btn_ThemHanhKhach.Location = new Point(139, 243);
            btn_ThemHanhKhach.Name = "btn_ThemHanhKhach";
            btn_ThemHanhKhach.Size = new Size(75, 23);
            btn_ThemHanhKhach.TabIndex = 10;
            btn_ThemHanhKhach.Text = "Thêm";
            btn_ThemHanhKhach.UseVisualStyleBackColor = true;
            btn_ThemHanhKhach.Click += btn_ThemHanhKhach_Click;
            // 
            // MH_ThemHanhKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 305);
            Controls.Add(btn_ThemHanhKhach);
            Controls.Add(btn_Thoat);
            Controls.Add(txtDienThoai);
            Controls.Add(txtID);
            Controls.Add(txtTenHanhKhach);
            Controls.Add(txtMaHanhKhach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_ThemHanhKhach";
            Text = "Thêm Hành Khách";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox txtMaHanhKhach;
        public TextBox txtTenHanhKhach;
        public TextBox txtID;
        public TextBox txtDienThoai;
        public Button btn_Thoat;
        public Button btn_ThemHanhKhach;
    }
}