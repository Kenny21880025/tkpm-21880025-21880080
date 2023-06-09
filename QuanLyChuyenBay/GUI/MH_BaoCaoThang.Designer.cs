namespace QuanLyChuyenBay
{
    partial class MH_BaoCaoThang
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
            cbThang = new ComboBox();
            cbNam = new ComboBox();
            btn_BaoCao = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Báo Cáo Doanh Thu Tháng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Tháng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 66);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Năm";
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(116, 63);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(61, 23);
            cbThang.TabIndex = 3;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(261, 63);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(61, 23);
            cbNam.TabIndex = 4;
            // 
            // btn_BaoCao
            // 
            btn_BaoCao.Location = new Point(188, 143);
            btn_BaoCao.Name = "btn_BaoCao";
            btn_BaoCao.Size = new Size(75, 23);
            btn_BaoCao.TabIndex = 5;
            btn_BaoCao.Text = "Báo Cáo";
            btn_BaoCao.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(285, 143);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // MH_BaoCaoThang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 190);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_BaoCao);
            Controls.Add(cbNam);
            Controls.Add(cbThang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MH_BaoCaoThang";
            Text = "MH_BaoCaoThang";
            Load += MH_BaoCaoThang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbThang;
        private ComboBox cbNam;
        private Button btn_BaoCao;
        private Button btn_Thoat;
    }
}