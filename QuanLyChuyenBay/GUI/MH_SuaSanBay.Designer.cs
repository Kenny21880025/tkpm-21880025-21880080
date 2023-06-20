namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaSanBay
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
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSanBay = new TextBox();
            txtTenSanBay = new TextBox();
            SuspendLayout();
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(66, 127);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 0;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(194, 127);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 1;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Sửa Thông Tin Sân Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Mã Sân Bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên Sân Bay";
            // 
            // txtMaSanBay
            // 
            txtMaSanBay.Location = new Point(129, 39);
            txtMaSanBay.Name = "txtMaSanBay";
            txtMaSanBay.Size = new Size(100, 23);
            txtMaSanBay.TabIndex = 5;
            // 
            // txtTenSanBay
            // 
            txtTenSanBay.Location = new Point(129, 79);
            txtTenSanBay.Name = "txtTenSanBay";
            txtTenSanBay.Size = new Size(100, 23);
            txtTenSanBay.TabIndex = 6;
            // 
            // MH_SuaSanBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 175);
            Controls.Add(txtTenSanBay);
            Controls.Add(txtMaSanBay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Name = "MH_SuaSanBay";
            Text = "MH_SuaSanBay";
            Load += MH_SuaSanBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CapNhat;
        private Button btn_Thoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSanBay;
        private TextBox txtTenSanBay;
    }
}