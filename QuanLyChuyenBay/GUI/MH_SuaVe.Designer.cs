namespace QuanLyChuyenBay.GUI
{
    partial class MH_SuaVe
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
            btn_Thoat = new Button();
            btn_CapNhat = new Button();
            txtSanBayDen = new TextBox();
            txtSanBayDi = new TextBox();
            txtMaTuyenBay = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(206, 174);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 18;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(99, 174);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 17;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // txtSanBayDen
            // 
            txtSanBayDen.Location = new Point(181, 124);
            txtSanBayDen.Name = "txtSanBayDen";
            txtSanBayDen.Size = new Size(100, 23);
            txtSanBayDen.TabIndex = 16;
            // 
            // txtSanBayDi
            // 
            txtSanBayDi.Location = new Point(181, 91);
            txtSanBayDi.Name = "txtSanBayDi";
            txtSanBayDi.Size = new Size(100, 23);
            txtSanBayDi.TabIndex = 15;
            // 
            // txtMaTuyenBay
            // 
            txtMaTuyenBay.Location = new Point(181, 58);
            txtMaTuyenBay.Name = "txtMaTuyenBay";
            txtMaTuyenBay.Size = new Size(100, 23);
            txtMaTuyenBay.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 94);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Mã Vé";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 10;
            label1.Text = "Sửa Thông Tin Vé";
            // 
            // MH_SuaVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 241);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(txtSanBayDen);
            Controls.Add(txtSanBayDi);
            Controls.Add(txtMaTuyenBay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_SuaVe";
            Text = "MH_SuaVe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Thoat;
        private Button btn_CapNhat;
        private TextBox txtSanBayDen;
        private TextBox txtSanBayDi;
        private TextBox txtMaTuyenBay;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}