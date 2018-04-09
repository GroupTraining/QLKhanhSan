using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLKhachSan.GUI
{
    public partial class frmChinhsuaDV : Form
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        Bus bus = new Bus();
        public frmChinhsuaDV()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CenterToParent();
            dataGridViewX1.DataSource = bus.getalldv();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.add_dv(txt_id.Text,txt_name.Text,Convert.ToInt32(txt_amount.Text));
                MessageBox.Show("Thêm thành công thành công !!");
                txt_id.Text = "";
                txt_name.Text = "";
                txt_amount.Text = "";
            }
            dataGridViewX1.DataSource = bus.getalldv();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn lưu lại chỉnh sửa  dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.edit_dv(txt_id.Text, txt_name.Text, Convert.ToInt32(txt_amount.Text));
                MessageBox.Show("Lưu thành công công thành công !!");
                txt_id.Text = "";
                txt_name.Text = "";
                txt_amount.Text = "";
            }
            btn_add.Show();
            dataGridViewX1.DataSource = bus.getalldv();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.del_dv(txt_id.Text);
                MessageBox.Show("Xóa thành công !!");
            }
            btn_add.Show();
            dataGridViewX1.DataSource = bus.getalldv();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_add.Hide();
            int rowindex = dataGridViewX1.CurrentCell.RowIndex;
            int columnindex = dataGridViewX1.CurrentCell.ColumnIndex;
            txt_id.Enabled = false;
            txt_id.Text = dataGridViewX1.Rows[rowindex].Cells[0].Value.ToString();
            txt_name.Text = dataGridViewX1.Rows[rowindex].Cells[1].Value.ToString();
            txt_amount.Text = dataGridViewX1.Rows[rowindex].Cells[2].Value.ToString();
        }
    }
}
