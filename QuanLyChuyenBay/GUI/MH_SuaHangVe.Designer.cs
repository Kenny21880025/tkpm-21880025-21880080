namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaHangVe
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
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            txtMaHangVe = new TextBox();
            txtTenHangVe = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 22);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Sửa Thông Tin Hạng Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Hạng Vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 97);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Hạng Vé";
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(89, 129);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 3;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(191, 129);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txtMaHangVe
            // 
            txtMaHangVe.Location = new Point(142, 55);
            txtMaHangVe.Name = "txtMaHangVe";
            txtMaHangVe.Size = new Size(100, 23);
            txtMaHangVe.TabIndex = 5;
            // 
            // txtTenHangVe
            // 
            txtTenHangVe.Location = new Point(142, 89);
            txtTenHangVe.Name = "txtTenHangVe";
            txtTenHangVe.Size = new Size(100, 23);
            txtTenHangVe.TabIndex = 6;
            // 
            // MH_SuaHangVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 177);
            Controls.Add(txtTenHangVe);
            Controls.Add(txtMaHangVe);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_SuaHangVe";
            Text = "MH_SuaHangVe";
            Load += MH_SuaHangVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private TextBox txtMaHangVe;
        private TextBox txtTenHangVe;
    }
}