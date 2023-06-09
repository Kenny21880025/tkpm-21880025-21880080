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
            button1 = new Button();
            button2 = new Button();
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
            // button1
            // 
            button1.Location = new Point(232, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cập Nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(339, 139);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private TextBox txtTimeOrder;
        private TextBox txtTimeCancel;
    }
}