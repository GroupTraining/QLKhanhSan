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
using DAL;

namespace QLKhachSan.GUI
{
    public partial class frmChinhsuahddv : Form
    {
        Bus bus = new Bus();
        DataDiagramDataContext data = new DataDiagramDataContext();
        public frmChinhsuahddv()
        {
            InitializeComponent();
        }
        private void frmChinhsuahddv_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = bus.getDataHDDV();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = bus.TimKiem_Hddv(txtSearch.Text);
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHD.Text = dataGridViewX1.CurrentRow.Cells["MaHD"].Value.ToString();
            txtHoTen.Text = dataGridViewX1.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDV.Text = dataGridViewX1.CurrentRow.Cells["TenDV"].Value.ToString();
            dateTimeDV.Text = dataGridViewX1.CurrentRow.Cells["NgayLap"].Value.ToString();
            txtSoLg.Text = dataGridViewX1.CurrentRow.Cells["SoLuongDV"].Value.ToString();
            txtTongTien.Text = dataGridViewX1.CurrentRow.Cells["ThanhTien"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chỉnh sửa dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dichvu = data.DichVus.Single(a => a.TenDV == txtDV.Text);
                bus.EditHddv(txtHD.Text, dichvu.MaDV, txtSoLg.Text);
                MessageBox.Show("Cập nhật thành công !!");
                txtDV.Text = "";
                txtHD.Text = "";
                txtHoTen.Text = "";
                txtSoLg.Text = "";
                txtTongTien.Text = "";
                dateTimeDV.Value = DateTime.Now;
            }
            dataGridViewX1.DataSource = bus.getDataHDDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dichvu = data.DichVus.Single(a => a.TenDV == txtDV.Text);
                bus.delHddv(txtHD.Text, dichvu.MaDV);
                MessageBox.Show("Xóa thành công !!");
                txtDV.Text = "";
                txtHD.Text = "";
                txtHoTen.Text = "";
                txtSoLg.Text = "";
                txtTongTien.Text = "";
                dateTimeDV.Value = DateTime.Now;
            }
            dataGridViewX1.DataSource = bus.getDataHDDV();
        }
    }
}
