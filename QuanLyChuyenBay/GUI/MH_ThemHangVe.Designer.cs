namespace QuanLyChuyenBay.GUI
{
    partial class MH_ThemHangVe
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
            txtMaHangVe = new TextBox();
            txtTenHangVe = new TextBox();
            btn_LuuHangVe = new Button();
            btn_Them = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Thêm Hạng Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 61);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Hạng Vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 99);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Hạng Vé";
            // 
            // txtMaHangVe
            // 
            txtMaHangVe.Location = new Point(150, 58);
            txtMaHangVe.Name = "txtMaHangVe";
            txtMaHangVe.Size = new Size(191, 23);
            txtMaHangVe.TabIndex = 3;
            txtMaHangVe.TextChanged += txtMaHangVe_TextChanged;
            // 
            // txtTenHangVe
            // 
            txtTenHangVe.Location = new Point(150, 96);
            txtTenHangVe.Name = "txtTenHangVe";
            txtTenHangVe.Size = new Size(191, 23);
            txtTenHangVe.TabIndex = 4;
            txtTenHangVe.TextChanged += txtTenHangVe_TextChanged;
            // 
            // btn_LuuHangVe
            // 
            btn_LuuHangVe.Location = new Point(43, 154);
            btn_LuuHangVe.Name = "btn_LuuHangVe";
            btn_LuuHangVe.Size = new Size(75, 23);
            btn_LuuHangVe.TabIndex = 5;
            btn_LuuHangVe.Text = "Lưu";
            btn_LuuHangVe.UseVisualStyleBackColor = true;
            btn_LuuHangVe.Click += btn_LuuHangVe_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(165, 154);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Xóa trắng";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(287, 154);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 7;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // MH_ThemHangVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 223);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Them);
            Controls.Add(btn_LuuHangVe);
            Controls.Add(txtTenHangVe);
            Controls.Add(txtMaHangVe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_ThemHangVe";
            Text = "Thêm Hạng Vé";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaHangVe;
        private TextBox txtTenHangVe;
        private Button btn_LuuHangVe;
        private Button btn_Them;
        private Button btn_Thoat;
    }
}