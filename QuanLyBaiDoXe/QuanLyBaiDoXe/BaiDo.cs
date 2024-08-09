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
    public partial class frm_baido : Form
    {
        public frm_baido()
        {
            InitializeComponent();
            ldc = new LopDungChung();
        }
        LopDungChung ldc;
        private void frm_baido_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCombo1();
            LoadCombo2();
        }
        public void LoadGrid()
        {
            dataGridView1.DataSource = ldc.LoadData("Select * from BAIDO");
            dataGridView1.Columns[0].HeaderText = "Mã Vị Trí";
            dataGridView1.Columns[1].HeaderText = "Tên Vị Trí";
            dataGridView1.Columns[2].HeaderText = "Khu Vực";
            dataGridView1.Columns[3].HeaderText = "Trạng Thái";
        }
        public void LoadCombo1()
        {
            cb_Khuvuc.DataSource = ldc.LoadData("Select distinct KhuVuc from BAIDO");
            cb_Khuvuc.DisplayMember = "KhuVuc";
            cb_Khuvuc.ValueMember = "KhuVuc";
        }
        public void LoadCombo2()
        {
            cb_Trangthai.DataSource = ldc.LoadData("Select distinct TrangThai from BAIDO");
            cb_Trangthai.DisplayMember = "TrangThai";
            cb_Trangthai.ValueMember = "TrangThai";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into BAIDO values('" + txt_MaVT.Text + "', '" + txt_TenVT.Text + "','" + cb_Khuvuc.SelectedValue + "', N'" + cb_Trangthai.SelectedValue + "')";
            ldc.NonQuery(sqlThem);
            LoadGrid();
        }
        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string sqlXoa = "delete from BAIDO where MaVT='" + txt_MaVT.Text + "'";
            ldc.NonQuery(sqlXoa);
            LoadGrid();
            LoadCombo2();
        }
        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string sqlSua = "update BAIDO set TenVT=N'" + txt_TenVT.Text + "', KhuVuc='" + cb_Khuvuc.SelectedValue + "', TrangThai=N'" + cb_Trangthai.SelectedValue + "' where MaVT='" + txt_MaVT.Text + "'";
            ldc.NonQuery(sqlSua);
            LoadGrid();
        }
        private void btn_Loadlai_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_trangchu frm_Trangchu = new frm_trangchu();
            frm_Trangchu.Show();
            Hide();
        }

        private void frm_baido_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_trangchu frm_Trangchu = new frm_trangchu();
            frm_Trangchu.Show();
            Hide();
        }
        int chon = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaVT.Text = dataGridView1.CurrentRow.Cells["MaVT"].Value.ToString();
            txt_TenVT.Text = dataGridView1.CurrentRow.Cells["TenVT"].Value.ToString();
            chon = 1;
            cb_Khuvuc.SelectedValue = dataGridView1.CurrentRow.Cells["KhuVuc"].Value.ToString();
            chon = 0;
            cb_Trangthai.SelectedValue = dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString();
        }
        private void cb_Khuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string sqlLoadGrid = "select * from BAIDO where KhuVuc ='" + cb_Khuvuc.SelectedValue + "'";
                dataGridView1.DataSource = ldc.LoadData(sqlLoadGrid);
            }
        }
    }
}
