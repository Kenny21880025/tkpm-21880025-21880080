namespace QuanLyChuyenBay.GUI
{
    partial class MH_DSKhachHang
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
            label1 = new Label();
            txtMaHanhKhach = new TextBox();
            grvKhachHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // btn_LayDS
            // 
            btn_LayDS.Location = new Point(45, 32);
            btn_LayDS.Name = "btn_LayDS";
            btn_LayDS.Size = new Size(97, 23);
            btn_LayDS.TabIndex = 0;
            btn_LayDS.Text = "Lấy Danh Sách";
            btn_LayDS.UseVisualStyleBackColor = true;
            btn_LayDS.Click += btn_LayDS_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(158, 32);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(261, 32);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(370, 32);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 3;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 71);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã cần xóa/sửa";
            // 
            // txtMaHanhKhach
            // 
            txtMaHanhKhach.Location = new Point(345, 68);
            txtMaHanhKhach.Name = "txtMaHanhKhach";
            txtMaHanhKhach.Size = new Size(100, 23);
            txtMaHanhKhach.TabIndex = 5;
            // 
            // grvKhachHang
            // 
            grvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvKhachHang.Location = new Point(45, 120);
            grvKhachHang.Name = "grvKhachHang";
            grvKhachHang.RowTemplate.Height = 25;
            grvKhachHang.Size = new Size(400, 156);
            grvKhachHang.TabIndex = 6;
            // 
            // MH_DSKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 314);
            Controls.Add(grvKhachHang);
            Controls.Add(txtMaHanhKhach);
            Controls.Add(label1);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDS);
            Name = "MH_DSKhachHang";
            Text = "MH_DSKhachHang";
            ((System.ComponentModel.ISupportInitialize)grvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LayDS;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Label label1;
        private TextBox txtMaHanhKhach;
        private DataGridView grvKhachHang;
    }
}