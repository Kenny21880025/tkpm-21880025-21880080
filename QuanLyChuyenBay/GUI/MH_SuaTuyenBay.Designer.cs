namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaTuyenBay
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
            label4 = new Label();
            txtMaTuyenBay = new TextBox();
            txtSanBayDi = new TextBox();
            txtSanBayDen = new TextBox();
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Sửa Thông Tin Tuyến Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 46);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã Tuyến Bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 79);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Sân Bay Đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 117);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Sân Bay Đến";
            // 
            // txtMaTuyenBay
            // 
            txtMaTuyenBay.Location = new Point(151, 43);
            txtMaTuyenBay.Name = "txtMaTuyenBay";
            txtMaTuyenBay.Size = new Size(100, 23);
            txtMaTuyenBay.TabIndex = 5;
            // 
            // txtSanBayDi
            // 
            txtSanBayDi.Location = new Point(151, 76);
            txtSanBayDi.Name = "txtSanBayDi";
            txtSanBayDi.Size = new Size(100, 23);
            txtSanBayDi.TabIndex = 6;
            // 
            // txtSanBayDen
            // 
            txtSanBayDen.Location = new Point(151, 109);
            txtSanBayDen.Name = "txtSanBayDen";
            txtSanBayDen.Size = new Size(100, 23);
            txtSanBayDen.TabIndex = 7;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(69, 159);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 8;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(176, 159);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 9;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // MH_SuaTuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 219);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(txtSanBayDen);
            Controls.Add(txtSanBayDi);
            Controls.Add(txtMaTuyenBay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_SuaTuyenBay";
            Text = "MH_SuaTuyenBay";
            Load += MH_SuaTuyenBay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaTuyenBay;
        private TextBox txtSanBayDi;
        private TextBox txtSanBayDen;
        private Button btn_CapNhat;
        private Button btn_Thoat;
    }
}