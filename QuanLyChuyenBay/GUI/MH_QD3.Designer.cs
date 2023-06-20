namespace QuanLyChuyenBay.GUI
{
    partial class MH_QD3
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
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            txtTimeOrder = new TextBox();
            txtTimeCancel = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Quy Định Hạn Đặt Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 59);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 1;
            label2.Text = "Thời Gian Chậm Nhất Khi Đặt Vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 93);
            label3.Name = "label3";
            label3.Size = new Size(202, 15);
            label3.TabIndex = 2;
            label3.Text = "Thời Gian Chậm Nhất Khi Hủy Đặt Vé";
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(232, 139);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 3;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(339, 139);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txtTimeOrder
            // 
            txtTimeOrder.Location = new Point(280, 56);
            txtTimeOrder.Name = "txtTimeOrder";
            txtTimeOrder.Size = new Size(100, 23);
            txtTimeOrder.TabIndex = 5;
            // 
            // txtTimeCancel
            // 
            txtTimeCancel.Location = new Point(280, 90);
            txtTimeCancel.Name = "txtTimeCancel";
            txtTimeCancel.Size = new Size(100, 23);
            txtTimeCancel.TabIndex = 6;
            // 
            // MH_QD3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 174);
            Controls.Add(txtTimeCancel);
            Controls.Add(txtTimeOrder);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_QD3";
            Text = "Quy Định 3";
            Load += MH_QD3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private TextBox txtTimeOrder;
        private TextBox txtTimeCancel;
    }
}