using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLKhachSan.GUI
{
    public partial class frmChinhsuahdtt : Form
    {
        Bus code = new Bus();
        public frmChinhsuahdtt()
        {
            InitializeComponent();

            dataGridView1.DataSource = code.get_Hdtt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["MaHDTT"].Value != null)
            {
                txtMahdtt.Text = dataGridView1.CurrentRow.Cells["MaHDTT"].Value.ToString();
            }
            else
            {
                txtMahdtt.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaPhong"].Value != null)
            {
                txtMap.Text = dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString();
            }
            else
            {
                txtMap.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaKHTT"].Value != null)
            {
                txtMakhtt.Text = dataGridView1.CurrentRow.Cells["MaKHTT"].Value.ToString();
            }
            else
            {
                txtMakhtt.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["NgayThanhToan"].Value != null)
            {
                dtpN.Text = dataGridView1.CurrentRow.Cells["NgayThanhToan"].Value.ToString();
            }
            else
            {
                dtpN.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["TongTienThanhToan"].Value != null)
            {
                txtTien.Text = dataGridView1.CurrentRow.Cells["TongTienThanhToan"].Value.ToString();
            }
            else
            {
                txtTien.Text = "";
            }
            if (dataGridView1.CurrentRow.Cells["MaNV"].Value != null)
            {
                txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            }
            else
            {
                txtManv.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemhdtt themkh = null;
            Check_Them:
            if (themkh == null || themkh.IsDisposed)
            {
                themkh = new frmThemhdtt();
            }
            if (themkh.ShowDialog() == DialogResult.OK)
            {
                if (frmThemhdtt.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = code.get_Hdtt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            code.edit_Hdtt(txtMahdtt.Text, txtMap.Text, txtMakhtt.Text, dtpN.Text, txtTien.Text, txtManv.Text);
            dataGridView1.DataSource = code.get_Hdtt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            code.delete_Hdtt(txtMahdtt.Text);
            dataGridView1.DataSource = code.get_Hdtt();
        }
    }
}
