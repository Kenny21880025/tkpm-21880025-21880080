namespace QuanLyChuyenBay.GUI
{
    partial class MH_QD2
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
            txtSoLuongHangGiaVe = new TextBox();
            grvBangDonGiaVe = new DataGridView();
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)grvBangDonGiaVe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Quy Định Hạng Vé - Đơn Giá Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 54);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng Các Hạng Giá Vé";
            // 
            // txtSoLuongHangGiaVe
            // 
            txtSoLuongHangGiaVe.Location = new Point(210, 51);
            txtSoLuongHangGiaVe.Name = "txtSoLuongHangGiaVe";
            txtSoLuongHangGiaVe.Size = new Size(159, 23);
            txtSoLuongHangGiaVe.TabIndex = 2;
            // 
            // grvBangDonGiaVe
            // 
            grvBangDonGiaVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvBangDonGiaVe.Location = new Point(12, 145);
            grvBangDonGiaVe.Name = "grvBangDonGiaVe";
            grvBangDonGiaVe.RowTemplate.Height = 25;
            grvBangDonGiaVe.Size = new Size(386, 117);
            grvBangDonGiaVe.TabIndex = 3;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(98, 109);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 4;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(249, 109);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // MH_QD2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 274);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(grvBangDonGiaVe);
            Controls.Add(txtSoLuongHangGiaVe);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_QD2";
            Text = "Quy Định 2";
            Load += MH_QD2_Load;
            ((System.ComponentModel.ISupportInitialize)grvBangDonGiaVe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoLuongHangGiaVe;
        private DataGridView grvBangDonGiaVe;
        private Button btn_CapNhat;
        private Button btn_Thoat;
    }
}