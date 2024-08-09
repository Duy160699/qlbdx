namespace QuanLyBaiDoXe
{
    partial class frm_quenmk
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
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_tk = new System.Windows.Forms.Label();
            this.txt_tkcu = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(171, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = " Quên Mật Khẩu";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(262, 230);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(88, 39);
            this.btn_xacnhan.TabIndex = 2;
            this.btn_xacnhan.Text = " Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.Location = new System.Drawing.Point(22, 159);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(173, 26);
            this.lb_mk.TabIndex = 5;
            this.lb_mk.Text = " Mật Khẩu Mới";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.BackColor = System.Drawing.Color.Teal;
            this.lb_tk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk.Location = new System.Drawing.Point(74, 107);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(121, 26);
            this.lb_tk.TabIndex = 4;
            this.lb_tk.Text = "Tài Khoản";
            // 
            // txt_tkcu
            // 
            this.txt_tkcu.BackColor = System.Drawing.Color.Honeydew;
            this.txt_tkcu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tkcu.Location = new System.Drawing.Point(218, 104);
            this.txt_tkcu.Name = "txt_tkcu";
            this.txt_tkcu.Size = new System.Drawing.Size(280, 34);
            this.txt_tkcu.TabIndex = 6;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.BackColor = System.Drawing.Color.Honeydew;
            this.txt_mkmoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(218, 156);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(280, 34);
            this.txt_mkmoi.TabIndex = 7;
            // 
            // frm_quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(641, 320);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_tkcu);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tk);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.label1);
            this.Name = "frm_quenmk";
            this.Text = "QuenMatKhau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_quenmk_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.TextBox txt_tkcu;
        private System.Windows.Forms.TextBox txt_mkmoi;
    }
}