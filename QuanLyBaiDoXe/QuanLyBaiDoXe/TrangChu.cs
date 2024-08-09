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
    public partial class frm_trangchu : Form
    {
        public frm_trangchu()
        {
            InitializeComponent();
        }
        private void frm_trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {           
            frm_dangnhap frm_dangnhap = new frm_dangnhap();
            frm_dangnhap.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_nv frm_Nv = new frm_nv();
            frm_Nv.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_baido frm_Baido = new frm_baido();
            frm_Baido.Show();
            this.Hide();
        }
    }
}
