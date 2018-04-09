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
    public partial class frmChinhsuaphong : Form
    {
        Bus bus = new Bus();
        public frmChinhsuaphong()
        {
            InitializeComponent();
            dataGridView1.DataSource = bus.get_phong();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bus.them_phong(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                dataGridView1.Refresh();
                dataGridView1.DataSource = bus.get_phong();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                MessageBox.Show("Thêm thành công !");

            }
            catch(Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Không thêm được! Thêm lại !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["SoPhong"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["LoaiPhong"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["GiaPhong"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["TinhTrangPhong"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muôn sửa không?","Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                bus.sua_phong(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Chỉnh sửa thành công !");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dataGridView1.Refresh();
                dataGridView1.DataSource = bus.get_phong();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muôn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                bus.xoa_phong(textBox1.Text);
                MessageBox.Show("Xóa thành công");
                dataGridView1.Refresh();
                dataGridView1.DataSource = bus.get_phong();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
