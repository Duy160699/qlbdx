using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void frm_dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int dem = 0;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            LopDungChung ldc = new LopDungChung();
            int kq = ldc.Scalar("Select count(*) from TAIKHOAN where Taikhoan = '" + txt_tk.Text.ToString() + "'and Matkhau= '" + txt_mk.Text.ToString() + "'");
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            if (string.IsNullOrWhiteSpace(tk) || string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu");
                return;
            }
            if (kq > 0)
            {
                MessageBox.Show("Đăng Nhập thành công");
                Hide();
                frm_trangchu frm_trangchu = new frm_trangchu();
                frm_trangchu.Show();
                dem = 0;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                dem++;
            }
            if (dem == 3)
            {
                MessageBox.Show("Nhập sai 3 lần, hệ thống thoát");
                Close();
            }
        }

        private void llb_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_dangky frm_Dangky = new frm_dangky();
            frm_Dangky.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_quenmk frm_Quenmk = new frm_quenmk();
            frm_Quenmk.Show();
            this.Hide();
        }
    }
}
