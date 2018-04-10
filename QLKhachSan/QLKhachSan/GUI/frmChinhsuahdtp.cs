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
            textBox1.Text = dataGridViewHdtp.CurrentRow.Cells["MaPhong"].Value.ToString();
            textBox2.Text = dataGridViewHdtp.CurrentRow.Cells["TenKHThue"].Value.ToString();
            textBox4.Text = dataGridViewHdtp.CurrentRow.Cells["ThoiGianThue"].Value.ToString();
            textBox3.Text = dataGridViewHdtp.CurrentRow.Cells["TienPhong"].Value.ToString();
            dateTimePicker1.Text = dataGridViewHdtp.CurrentRow.Cells["NgayThue"].Value.ToString();
            dateTimePicker2.Text = dataGridViewHdtp.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        int thanhtien = 0;
        DateTime ngayden;
        DateTime ngaytra;
        TimeSpan thoigianthue;
        DateTime time = DateTime.Now;

        private void comboBoxLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ngayden = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ngaytra = DateTime.ParseExact(dateTimePicker2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            thoigianthue = ngaytra - ngayden;
            if (thoigianthue.TotalHours < 0)
            {
                MessageBox.Show("Nhập lại giá trị ngày trả phòng");
                return;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            bus.EditHdtp(textBox1.Text,dateTimePicker1.Text, dateTimePicker2.Text);
            MessageBox.Show("Chỉnh sửa thành công!!");
            textBox1.Text = "";
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
            dataGridViewHdtp.DataSource = bus.get_suaHdtp();
        }
    }
}
