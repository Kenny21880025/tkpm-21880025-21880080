namespace QuanLyChuyenBay
{
    partial class MH_BaoCaoNam
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
            label3 = new Label();
            cbNam = new ComboBox();
            btn_BaoCao = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Báo Cáo Doanh Thu Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 60);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Năm";
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(84, 57);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(61, 23);
            cbNam.TabIndex = 4;
            // 
            // btn_BaoCao
            // 
            btn_BaoCao.Location = new Point(84, 109);
            btn_BaoCao.Name = "btn_BaoCao";
            btn_BaoCao.Size = new Size(75, 23);
            btn_BaoCao.TabIndex = 5;
            btn_BaoCao.Text = "Báo Cáo";
            btn_BaoCao.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(181, 109);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(75, 23);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // MH_BaoCaoNam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 172);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_BaoCao);
            Controls.Add(cbNam);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "MH_BaoCaoNam";
            Text = "MH_BaoCaoThang";
            Load += MH_BaoCaoNam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox cbNam;
        private Button btn_BaoCao;
        private Button btn_Thoat;
    }
}