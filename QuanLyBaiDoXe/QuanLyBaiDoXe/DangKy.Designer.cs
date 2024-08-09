namespace QuanLyBaiDoXe
{
    partial class frm_dangky
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tkdk = new System.Windows.Forms.TextBox();
            this.txt_mkdk = new System.Windows.Forms.TextBox();
            this.txt_mkl2 = new System.Windows.Forms.TextBox();
            this.btn_dkchinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(213, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(210, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = " Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(108, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = " Nhập Lại Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(298, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đăng Ký";
            // 
            // txt_tkdk
            // 
            this.txt_tkdk.Location = new System.Drawing.Point(368, 151);
            this.txt_tkdk.Name = "txt_tkdk";
            this.txt_tkdk.Size = new System.Drawing.Size(185, 22);
            this.txt_tkdk.TabIndex = 4;
            // 
            // txt_mkdk
            // 
            this.txt_mkdk.Location = new System.Drawing.Point(368, 211);
            this.txt_mkdk.Name = "txt_mkdk";
            this.txt_mkdk.PasswordChar = '*';
            this.txt_mkdk.Size = new System.Drawing.Size(185, 22);
            this.txt_mkdk.TabIndex = 5;
            // 
            // txt_mkl2
            // 
            this.txt_mkl2.Location = new System.Drawing.Point(368, 268);
            this.txt_mkl2.Name = "txt_mkl2";
            this.txt_mkl2.PasswordChar = '*';
            this.txt_mkl2.Size = new System.Drawing.Size(185, 22);
            this.txt_mkl2.TabIndex = 6;
            // 
            // btn_dkchinh
            // 
            this.btn_dkchinh.Location = new System.Drawing.Point(315, 339);
            this.btn_dkchinh.Name = "btn_dkchinh";
            this.btn_dkchinh.Size = new System.Drawing.Size(122, 42);
            this.btn_dkchinh.TabIndex = 7;
            this.btn_dkchinh.Text = " Đăng Ký";
            this.btn_dkchinh.UseVisualStyleBackColor = true;
            this.btn_dkchinh.Click += new System.EventHandler(this.btn_dkchinh_Click);
            // 
            // frm_dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dkchinh);
            this.Controls.Add(this.txt_mkl2);
            this.Controls.Add(this.txt_mkdk);
            this.Controls.Add(this.txt_tkdk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_dangky";
            this.Text = "DangKy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_dangky_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tkdk;
        private System.Windows.Forms.TextBox txt_mkdk;
        private System.Windows.Forms.TextBox txt_mkl2;
        private System.Windows.Forms.Button btn_dkchinh;
    }
}