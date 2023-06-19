namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaHanhKhach
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
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            txtMaHanhKhach = new TextBox();
            txtID = new TextBox();
            txtDienThoai = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Sửa Thông Tin Hành Khách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 32);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Hành Khách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 75);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại Mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 119);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Số CCCD Mới";
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(149, 175);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 4;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(254, 175);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txtMaHanhKhach
            // 
            txtMaHanhKhach.Location = new Point(167, 27);
            txtMaHanhKhach.Name = "txtMaHanhKhach";
            txtMaHanhKhach.Size = new Size(132, 23);
            txtMaHanhKhach.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(132, 23);
            txtID.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(167, 72);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(132, 23);
            txtDienThoai.TabIndex = 8;
            // 
            // MH_SuaHanhKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 234);
            Controls.Add(txtDienThoai);
            Controls.Add(txtID);
            Controls.Add(txtMaHanhKhach);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_SuaHanhKhach";
            Text = "MH_SuaHanhKhach";
            Load += MH_SuaHanhKhach_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private TextBox txtMaHanhKhach;
        private TextBox txtID;
        private TextBox txtDienThoai;
    }
}