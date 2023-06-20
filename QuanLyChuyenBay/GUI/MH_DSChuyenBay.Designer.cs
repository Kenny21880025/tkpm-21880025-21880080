namespace QuanLyChuyenBay.GUI
{
    partial class MH_DSChuyenBay
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
            btn_LayDanhSach = new Button();
            btn_Them = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            grvChuyenBay = new DataGridView();
            label1 = new Label();
            txtMaChuyenBay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grvChuyenBay).BeginInit();
            SuspendLayout();
            // 
            // btn_LayDanhSach
            // 
            btn_LayDanhSach.Location = new Point(64, 49);
            btn_LayDanhSach.Name = "btn_LayDanhSach";
            btn_LayDanhSach.Size = new Size(96, 23);
            btn_LayDanhSach.TabIndex = 0;
            btn_LayDanhSach.Text = "Lấy Danh Sách";
            btn_LayDanhSach.UseVisualStyleBackColor = true;
            btn_LayDanhSach.Click += btn_LayDanhSach_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(188, 49);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(316, 49);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(441, 49);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 3;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // grvChuyenBay
            // 
            grvChuyenBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvChuyenBay.Location = new Point(64, 131);
            grvChuyenBay.Name = "grvChuyenBay";
            grvChuyenBay.RowTemplate.Height = 25;
            grvChuyenBay.Size = new Size(452, 212);
            grvChuyenBay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 89);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 5;
            label1.Text = "Mã chuyến bay cần xóa/sửa";
            // 
            // txtMaChuyenBay
            // 
            txtMaChuyenBay.Location = new Point(416, 86);
            txtMaChuyenBay.Name = "txtMaChuyenBay";
            txtMaChuyenBay.Size = new Size(100, 23);
            txtMaChuyenBay.TabIndex = 6;
            // 
            // MH_DSChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 388);
            Controls.Add(txtMaChuyenBay);
            Controls.Add(label1);
            Controls.Add(grvChuyenBay);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDanhSach);
            Name = "MH_DSChuyenBay";
            Text = "MH_DSChuyenBay";
            Load += MH_DSChuyenBay_Load;
            ((System.ComponentModel.ISupportInitialize)grvChuyenBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LayDanhSach;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_Sua;
        private DataGridView grvChuyenBay;
        private Label label1;
        private TextBox txtMaChuyenBay;
    }
}