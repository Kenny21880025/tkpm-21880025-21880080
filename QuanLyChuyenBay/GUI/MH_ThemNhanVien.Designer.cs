namespace QuanLyChuyenBay.GUI
{
    partial class MH_ThemNhanVien
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
            txtPW = new TextBox();
            txtID = new TextBox();
            btn_Thoat = new Button();
            btn_XoaTrang = new Button();
            btn_Luu = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPW
            // 
            txtPW.AcceptsReturn = true;
            txtPW.Location = new Point(150, 119);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(225, 23);
            txtPW.TabIndex = 15;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 69);
            txtID.Name = "txtID";
            txtID.Size = new Size(225, 23);
            txtID.TabIndex = 14;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(300, 182);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 13;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_XoaTrang
            // 
            btn_XoaTrang.Location = new Point(175, 182);
            btn_XoaTrang.Name = "btn_XoaTrang";
            btn_XoaTrang.Size = new Size(75, 23);
            btn_XoaTrang.TabIndex = 12;
            btn_XoaTrang.Text = "Xóa trắng";
            btn_XoaTrang.UseVisualStyleBackColor = true;
            btn_XoaTrang.Click += btn_XoaTrang_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(50, 182);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(75, 23);
            btn_Luu.TabIndex = 11;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 122);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 69);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 8;
            label1.Text = "Đăng Ký Người Dùng";
            // 
            // MH_ThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 253);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_XoaTrang);
            Controls.Add(btn_Luu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_ThemNhanVien";
            Text = "MH_ThemNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPW;
        private TextBox txtID;
        private Button btn_Thoat;
        private Button btn_XoaTrang;
        private Button btn_Luu;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}