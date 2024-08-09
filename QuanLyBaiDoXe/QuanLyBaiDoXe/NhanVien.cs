using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe
{
    public partial class frm_nv : Form
    {
        public frm_nv()
        {
            InitializeComponent();
            ldc = new LopDungChung();
        }
        LopDungChung ldc;
        private void frm_nv_Load(object sender, EventArgs e)
        {
            LoadGrid1();
        }
        public void LoadGrid1()
        {
            dataGridView1.DataSource = ldc.LoadData("Select * from NHANVIEN");
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            dataGridView1.Columns[2].HeaderText = "Năm Sinh";
            dataGridView1.Columns[3].HeaderText = "Giới Tinh";
            dataGridView1.Columns[4].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "Insert into NHANVIEN values ('" + txt_maNV.Text + "',N'" + txt_hoten.Text + "',Convert(Datetime,'" + dateTimePicker1.Text + "',103),N'"+txt_gioitinh.Text+"',N'"+txt_diachi.Text+"',N'"+txt_sdt.Text+"')";
            ldc.NonQuery(sqlThem);
            LoadGrid1();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update NHANVIEN set HoTen=N'" + txt_hoten.Text + "',NamSinh= Convert(Datetime,'" + dateTimePicker1.Text + "',103), GioiTinh=N'"+txt_gioitinh.Text+"', DiaChi=N'"+txt_diachi.Text+"', SĐT='"+txt_sdt.Text+"' where MaNV='"+txt_maNV.Text+"'";
            ldc.NonQuery(sqlSua);
            LoadGrid1();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from NHANVIEN where MaNV='" + txt_maNV.Text + "'";
            ldc.NonQuery(sqlXoa);
            LoadGrid1();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells["NamSinh"].Value.ToString();
            txt_gioitinh.Text= dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txt_diachi.Text= dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sdt.Text= dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
        }

        private void btn_Loadlai_Click(object sender, EventArgs e)
        {
            LoadGrid1();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_trangchu frm_Trangchu = new frm_trangchu();
            frm_Trangchu.Show();
            Hide();
        }

        private void frm_nv_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_trangchu frm_Trangchu = new frm_trangchu();
            frm_Trangchu.Show();
            Hide();
        }
    }
}
