namespace QuanLyChuyenBay.GUI
{
    partial class MH_QD1
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
            label5 = new Label();
            txtflymin = new TextBox();
            txttimestopmax = new TextBox();
            txttimestopmin = new TextBox();
            txtMiddleTerminal = new TextBox();
            btn_CapNhat = new Button();
            btn_Thoat = new Button();
            txtSoSanBay = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 27);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Quy Định Một Chuyến Bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 52);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Thời Gian Bay Tối Thiểu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 82);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 2;
            label3.Text = "Số Sân Bay Trung Gian Tối Đa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 111);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 3;
            label4.Text = "Thời Gian Dừng Tối Thiểu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 142);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Thời Gian Dừng Tối Đa";
            // 
            // txtflymin
            // 
            txtflymin.Location = new Point(216, 49);
            txtflymin.Name = "txtflymin";
            txtflymin.Size = new Size(100, 23);
            txtflymin.TabIndex = 5;
            // 
            // txttimestopmax
            // 
            txttimestopmax.Location = new Point(216, 139);
            txttimestopmax.Name = "txttimestopmax";
            txttimestopmax.Size = new Size(100, 23);
            txttimestopmax.TabIndex = 6;
            // 
            // txttimestopmin
            // 
            txttimestopmin.Location = new Point(216, 108);
            txttimestopmin.Name = "txttimestopmin";
            txttimestopmin.Size = new Size(100, 23);
            txttimestopmin.TabIndex = 7;
            // 
            // txtMiddleTerminal
            // 
            txtMiddleTerminal.Location = new Point(216, 79);
            txtMiddleTerminal.Name = "txtMiddleTerminal";
            txtMiddleTerminal.Size = new Size(100, 23);
            txtMiddleTerminal.TabIndex = 8;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(75, 218);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(75, 23);
            btn_CapNhat.TabIndex = 9;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(241, 218);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 10;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txtSoSanBay
            // 
            txtSoSanBay.Location = new Point(216, 168);
            txtSoSanBay.Name = "txtSoSanBay";
            txtSoSanBay.Size = new Size(100, 23);
            txtSoSanBay.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 171);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 11;
            label6.Text = "Số Sân Bay ";
            // 
            // MH_QD1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 253);
            Controls.Add(txtSoSanBay);
            Controls.Add(label6);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_CapNhat);
            Controls.Add(txtMiddleTerminal);
            Controls.Add(txttimestopmin);
            Controls.Add(txttimestopmax);
            Controls.Add(txtflymin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_QD1";
            Text = "Quy Định 1";
            Load += MH_QD1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtflymin;
        private TextBox txttimestopmax;
        private TextBox txttimestopmin;
        private TextBox txtMiddleTerminal;
        private Button btn_CapNhat;
        private Button btn_Thoat;
        private TextBox txtSoSanBay;
        private Label label6;
    }
}