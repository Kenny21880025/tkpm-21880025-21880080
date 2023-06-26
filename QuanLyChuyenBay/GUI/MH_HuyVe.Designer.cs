namespace QuanLyChuyenBay.GUI
{
    partial class MH_HuyVe
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
            grvSanBay = new DataGridView();
            txtMaVe = new TextBox();
            label1 = new Label();
            btn_Xoa = new Button();
            btn_Them = new Button();
            btn_LayDS = new Button();
            ((System.ComponentModel.ISupportInitialize)grvSanBay).BeginInit();
            SuspendLayout();
            // 
            // grvSanBay
            // 
            grvSanBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvSanBay.Location = new Point(64, 133);
            grvSanBay.Name = "grvSanBay";
            grvSanBay.RowTemplate.Height = 25;
            grvSanBay.Size = new Size(443, 210);
            grvSanBay.TabIndex = 13;
            // 
            // txtMaVe
            // 
            txtMaVe.Location = new Point(407, 87);
            txtMaVe.Name = "txtMaVe";
            txtMaVe.Size = new Size(100, 23);
            txtMaVe.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 90);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 11;
            label1.Text = "Nhập mã cần xóa/sửa";
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(432, 44);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 9;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(250, 44);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 8;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_LayDS
            // 
            btn_LayDS.Location = new Point(64, 44);
            btn_LayDS.Name = "btn_LayDS";
            btn_LayDS.Size = new Size(97, 23);
            btn_LayDS.TabIndex = 7;
            btn_LayDS.Text = "Lấy Danh Sách";
            btn_LayDS.UseVisualStyleBackColor = true;
            btn_LayDS.Click += btn_LayDS_Click;
            // 
            // MH_HuyVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 426);
            Controls.Add(grvSanBay);
            Controls.Add(txtMaVe);
            Controls.Add(label1);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDS);
            Name = "MH_HuyVe";
            Text = "MH_HuyVe";            
            ((System.ComponentModel.ISupportInitialize)grvSanBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grvSanBay;
        private TextBox txtMaVe;
        private Label label1;
        private Button btn_Xoa;
        private Button btn_Them;
        private Button btn_LayDS;
    }
}