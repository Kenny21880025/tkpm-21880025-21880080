namespace QuanLyChuyenBay.GUI
{
    partial class MH_DSSanBay
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
            txtMaSanBay = new TextBox();
            grvSanBay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvSanBay).BeginInit();
            SuspendLayout();
            // 
            // btn_LayDS
            // 
            btn_LayDS.Location = new Point(43, 35);
            btn_LayDS.Name = "btn_LayDS";
            btn_LayDS.Size = new Size(97, 23);
            btn_LayDS.TabIndex = 0;
            btn_LayDS.Text = "Lấy Danh Sách";
            btn_LayDS.UseVisualStyleBackColor = true;
            btn_LayDS.Click += btn_LayDS_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(156, 35);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(273, 35);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(394, 35);
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
            label1.Location = new Point(240, 86);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã cần xóa/sửa";
            // 
            // txtMaSanBay
            // 
            txtMaSanBay.Location = new Point(369, 83);
            txtMaSanBay.Name = "txtMaSanBay";
            txtMaSanBay.Size = new Size(100, 23);
            txtMaSanBay.TabIndex = 5;
            // 
            // grvSanBay
            // 
            grvSanBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvSanBay.Location = new Point(43, 130);
            grvSanBay.Name = "grvSanBay";
            grvSanBay.RowTemplate.Height = 25;
            grvSanBay.Size = new Size(426, 150);
            grvSanBay.TabIndex = 6;
            // 
            // MH_DSSanBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 328);
            Controls.Add(grvSanBay);
            Controls.Add(txtMaSanBay);
            Controls.Add(label1);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDS);
            Name = "MH_DSSanBay";
            Text = "MH_DSSanBay";
            ((System.ComponentModel.ISupportInitialize)grvSanBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LayDS;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Label label1;
        private TextBox txtMaSanBay;
        private DataGridView grvSanBay;
    }
}