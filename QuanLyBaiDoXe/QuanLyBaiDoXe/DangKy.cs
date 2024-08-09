using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe
{
    public partial class frm_dangky : Form
    {
        LopDungChung ldc;
        public frm_dangky()
        {
            InitializeComponent();
            ldc = new LopDungChung();
        }
        private void btn_dkchinh_Click(object sender, EventArgs e)
        {
            string sqlDangKy = "insert into TAIKHOAN values('" + txt_tkdk.Text.ToString() + "','" + txt_mkdk.Text.ToString() + "')";
            string tk = txt_tkdk.Text;
            string mk = txt_mkdk.Text;
            string nlmk = txt_mkl2.Text;
            if (string.IsNullOrWhiteSpace(tk) || string.IsNullOrWhiteSpace(mk) || string.IsNullOrWhiteSpace(nlmk))
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                return;
            }
            string checkUser = "SELECT COUNT(TaiKhoan) FROM TAIKHOAN WHERE TaiKhoan ='"+tk+"'";
            checkUser = checkUser.Replace("@tk", $"'{tk}'");
            int soLuongNguoiDung = ldc.Scalar(checkUser);
            if (soLuongNguoiDung > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                return;
            }
            if (mk != nlmk)
            {
                MessageBox.Show("Mật khẩu không khớp nhau");
                return;
            }
            ldc.NonQuery(sqlDangKy);
            MessageBox.Show("Đăng ký thành công! Bây giờ bạn có thể đăng nhập.");
            this.Hide();
            frm_dangnhap frm_Dangnhap = new frm_dangnhap();
            frm_Dangnhap.Show(); 
        }

        private void frm_dangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_dangnhap frm_Dangnhap = new frm_dangnhap();
            frm_Dangnhap.Show();
            this.Hide();
        }
    }
}
