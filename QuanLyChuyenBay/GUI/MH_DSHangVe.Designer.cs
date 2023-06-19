namespace QuanLyChuyenBay.GUI
{
    partial class MH_DSHangVe
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
            btn_LayDS = new Button();
            btn_Them = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            grvHangVe = new DataGridView();
            label1 = new Label();
            txtMaHangVe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grvHangVe).BeginInit();
            SuspendLayout();
            // 
            // btn_LayDS
            // 
            btn_LayDS.Location = new Point(72, 48);
            btn_LayDS.Name = "btn_LayDS";
            btn_LayDS.Size = new Size(98, 23);
            btn_LayDS.TabIndex = 0;
            btn_LayDS.Text = "Lấy Danh Sách";
            btn_LayDS.UseVisualStyleBackColor = true;
            btn_LayDS.Click += btn_LayDS_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(191, 48);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(323, 48);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(452, 48);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 3;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // grvHangVe
            // 
            grvHangVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvHangVe.Location = new Point(82, 116);
            grvHangVe.Name = "grvHangVe";
            grvHangVe.RowTemplate.Height = 25;
            grvHangVe.Size = new Size(445, 150);
            grvHangVe.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 87);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 5;
            label1.Text = "Nhập mã cần xóa/sửa";
            // 
            // txtMaHangVe
            // 
            txtMaHangVe.Location = new Point(427, 84);
            txtMaHangVe.Name = "txtMaHangVe";
            txtMaHangVe.Size = new Size(100, 23);
            txtMaHangVe.TabIndex = 6;
            // 
            // MH_DSHangVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 301);
            Controls.Add(txtMaHangVe);
            Controls.Add(label1);
            Controls.Add(grvHangVe);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDS);
            Name = "MH_DSHangVe";
            Text = "MH_DSHangVe";
            ((System.ComponentModel.ISupportInitialize)grvHangVe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LayDS;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_Sua;
        private DataGridView grvHangVe;
        private Label label1;
        private TextBox txtMaHangVe;
    }
}