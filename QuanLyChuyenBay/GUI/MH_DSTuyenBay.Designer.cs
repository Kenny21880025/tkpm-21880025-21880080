namespace QuanLyChuyenBay.GUI
{
    partial class MH_DSTuyenBay
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
            grvTuyenBay = new DataGridView();
            label1 = new Label();
            txtMaTuyenBay = new TextBox();
            btn_Sua = new Button();
            ((System.ComponentModel.ISupportInitialize)grvTuyenBay).BeginInit();
            SuspendLayout();
            // 
            // btn_LayDS
            // 
            btn_LayDS.Location = new Point(37, 50);
            btn_LayDS.Name = "btn_LayDS";
            btn_LayDS.Size = new Size(95, 23);
            btn_LayDS.TabIndex = 0;
            btn_LayDS.Text = "Lấy Danh Sách";
            btn_LayDS.UseVisualStyleBackColor = true;
            btn_LayDS.Click += btn_LayDS_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(162, 50);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(264, 50);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // grvTuyenBay
            // 
            grvTuyenBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvTuyenBay.Location = new Point(37, 116);
            grvTuyenBay.Name = "grvTuyenBay";
            grvTuyenBay.RowTemplate.Height = 25;
            grvTuyenBay.Size = new Size(504, 205);
            grvTuyenBay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 21);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 5;
            label1.Text = "Nhập mã tuyến bay cần xóa/sửa";
            // 
            // txtMaTuyenBay
            // 
            txtMaTuyenBay.Location = new Point(470, 50);
            txtMaTuyenBay.Name = "txtMaTuyenBay";
            txtMaTuyenBay.Size = new Size(71, 23);
            txtMaTuyenBay.TabIndex = 6;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(372, 49);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 7;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // MH_DSTuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 366);
            Controls.Add(btn_Sua);
            Controls.Add(txtMaTuyenBay);
            Controls.Add(label1);
            Controls.Add(grvTuyenBay);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(btn_LayDS);
            Name = "MH_DSTuyenBay";
            Text = "MH_DSTuyenBay";
            ((System.ComponentModel.ISupportInitialize)grvTuyenBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LayDS;
        private Button btn_Them;
        private Button btn_Xoa;
        private DataGridView grvTuyenBay;
        private Label label1;
        private TextBox txtMaTuyenBay;
        private Button btn_Sua;
    }
}