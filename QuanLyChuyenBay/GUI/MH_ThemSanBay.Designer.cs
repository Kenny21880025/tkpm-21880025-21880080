namespace QuanLyChuyenBay.GUI
{
    partial class MH_ThemSanBay
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
            btn_LuuSanBay = new Button();
            btn_ThemSanBay = new Button();
            btn_ThoatSanBay = new Button();
            txtMaSanBay = new TextBox();
            txtTenSanBay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "THÊM SÂN BAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 58);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Sân Bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 111);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Sân Bay";
            // 
            // btn_LuuSanBay
            // 
            btn_LuuSanBay.Location = new Point(66, 171);
            btn_LuuSanBay.Name = "btn_LuuSanBay";
            btn_LuuSanBay.Size = new Size(75, 23);
            btn_LuuSanBay.TabIndex = 3;
            btn_LuuSanBay.Text = "Lưu";
            btn_LuuSanBay.UseVisualStyleBackColor = true;
            btn_LuuSanBay.Click += btn_LuuSanBay_Click;
            // 
            // btn_ThemSanBay
            // 
            btn_ThemSanBay.Location = new Point(191, 171);
            btn_ThemSanBay.Name = "btn_ThemSanBay";
            btn_ThemSanBay.Size = new Size(75, 23);
            btn_ThemSanBay.TabIndex = 4;
            btn_ThemSanBay.Text = "Xóa trắng";
            btn_ThemSanBay.UseVisualStyleBackColor = true;
            btn_ThemSanBay.Click += btn_ThemSanBay_Click;
            // 
            // btn_ThoatSanBay
            // 
            btn_ThoatSanBay.Location = new Point(316, 171);
            btn_ThoatSanBay.Name = "btn_ThoatSanBay";
            btn_ThoatSanBay.Size = new Size(75, 23);
            btn_ThoatSanBay.TabIndex = 5;
            btn_ThoatSanBay.Text = "Thoát";
            btn_ThoatSanBay.UseVisualStyleBackColor = true;
            btn_ThoatSanBay.Click += btn_ThoatSanBay_Click;
            // 
            // txtMaSanBay
            // 
            txtMaSanBay.Location = new Point(166, 58);
            txtMaSanBay.Name = "txtMaSanBay";
            txtMaSanBay.Size = new Size(225, 23);
            txtMaSanBay.TabIndex = 6;
            // 
            // txtTenSanBay
            // 
            txtTenSanBay.AcceptsReturn = true;
            txtTenSanBay.Location = new Point(166, 108);
            txtTenSanBay.Name = "txtTenSanBay";
            txtTenSanBay.Size = new Size(225, 23);
            txtTenSanBay.TabIndex = 7;
            // 
            // MH_ThemSanBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 226);
            Controls.Add(txtTenSanBay);
            Controls.Add(txtMaSanBay);
            Controls.Add(btn_ThoatSanBay);
            Controls.Add(btn_ThemSanBay);
            Controls.Add(btn_LuuSanBay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_ThemSanBay";
            Text = "Thêm Sân Bay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_LuuSanBay;
        private Button btn_ThemSanBay;
        private Button btn_ThoatSanBay;
        private TextBox txtMaSanBay;
        private TextBox txtTenSanBay;
    }
}