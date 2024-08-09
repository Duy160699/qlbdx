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
    public partial class frm_quenmk : Form
    {
        public frm_quenmk()
        {
            InitializeComponent();
            ldc = new LopDungChung();
        }
        LopDungChung ldc;
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string sqlXacNhan = "update TAIKHOAN set MatKhau = '" + txt_mkmoi.Text + "' where TaiKhoan='" + txt_tkcu.Text + "'";
            int check = ldc.Scalar("select count (Taikhoan) from TAIKHOAN where Taikhoan = '" + txt_tkcu.Text + "'");
            if (check == 0)
            {
                MessageBox.Show("Tên tài khoản không tồn tại");
            }
            else
            {
                ldc.NonQuery(sqlXacNhan);
                Close();
            }

        }

        private void frm_quenmk_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_dangnhap frm_Dangnhap = new frm_dangnhap();
            frm_Dangnhap.Show();
            this.Hide();
        }
    }
}
