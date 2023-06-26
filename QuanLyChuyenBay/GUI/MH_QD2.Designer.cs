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
            grvBangDonGiaVe = new DataGridView();
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            label2 = new Label();
            txtSLHangVe = new TextBox();
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
            // grvBangDonGiaVe
            // 
            grvBangDonGiaVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvBangDonGiaVe.Location = new Point(12, 145);
            grvBangDonGiaVe.Name = "grvBangDonGiaVe";
            grvBangDonGiaVe.RowTemplate.Height = 25;
            grvBangDonGiaVe.Size = new Size(386, 117);
            grvBangDonGiaVe.TabIndex = 3;
            grvBangDonGiaVe.CellContentClick += grvBangDonGiaVe_CellContentClick;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(78, 95);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 4;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(201, 95);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 49);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 6;
            label2.Text = "Số Lượng Hạng Vé";
            // 
            // txtSLHangVe
            // 
            txtSLHangVe.Location = new Point(222, 46);
            txtSLHangVe.Name = "txtSLHangVe";
            txtSLHangVe.Size = new Size(100, 23);
            txtSLHangVe.TabIndex = 13;
            // 
            // MH_QD2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 274);
            Controls.Add(txtSLHangVe);
            Controls.Add(label2);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(grvBangDonGiaVe);
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
        private DataGridView grvBangDonGiaVe;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private Label label2;
        private TextBox txtSLHangVe;
    }
}