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
using System.Globalization;

namespace QLKhachSan.GUI
{
    public partial class frmChinhsuahdtp : Form
    {
        Bus bus = new Bus();
        public frmChinhsuahdtp()
        {
            InitializeComponent();
            dataGridViewHdtp.DataSource = bus.get_suaHdtp();
            dataGridViewHdtp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        private void dataGridViewHdtp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox1.Text = dataGridViewHdtp.CurrentRow.Cells["MaPhong"].Value.ToString();
            textBox5.Text = dataGridViewHdtp.CurrentRow.Cells["SoPhong"].Value.ToString();
            textBox2.Text = dataGridViewHdtp.CurrentRow.Cells["TenKHThue"].Value.ToString();
            textBox4.Text = dataGridViewHdtp.CurrentRow.Cells["ThoiGianThue"].Value.ToString();
            textBox3.Text = dataGridViewHdtp.CurrentRow.Cells["TienPhong"].Value.ToString();
            dateTimePicker1.Text = dataGridViewHdtp.CurrentRow.Cells["NgayThue"].Value.ToString();
            dateTimePicker2.Text = dataGridViewHdtp.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        DateTime ngayden;
        DateTime ngaytra;
        TimeSpan thoigianthue;
        

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ngayden = Convert.ToDateTime(dateTimePicker1.Text);
            ngaytra = Convert.ToDateTime(dateTimePicker2.Text);
            thoigianthue = ngaytra - ngayden;
            if (thoigianthue.TotalDays < 0)
            {
                MessageBox.Show("Nhập lại giá trị ngày trả phòng");
                return;
            }
            else
            {
                textBox4.Text = Convert.ToString(thoigianthue.TotalDays);
            }
                bus.EditHdtp(textBox1.Text,textBox5.Text,dateTimePicker1.Text, dateTimePicker2.Text,textBox4.Text);
            MessageBox.Show("Chỉnh sửa thành công!!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridViewHdtp.DataSource = bus.get_suaHdtp();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            bus.delHdtp(textBox1.Text);
            MessageBox.Show("Xóa thành công!!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridViewHdtp.DataSource = bus.get_suaHdtp();
        }
    }
}
