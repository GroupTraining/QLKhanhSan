using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKhachSan.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cHỈNHSỬAPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChinhsuaphong p = new frmChinhsuaphong();
            p.Show();
        }

        private void tÌMKIẾMPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemphong a = new frmTimkiemphong();
            a.Show();
        }

        private void tHỐNGKÊPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkephong b = new frmThongkephong();
            b.Show();
        }

        private void cHỈNHSỬADỊCHVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChinhsuaDV t = new frmChinhsuaDV();
            t.Show();
        }

        private void tÌMKIẾMDỊCHVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemdv g = new frmTimkiemdv();
            g.Show();
        }

        private void tHỐNGKÊDỊCHVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkedv h = new frmThongkedv();
            h.Show();
        }

        private void cHỈNHSỬAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChinhsuahddv k = new frmChinhsuahddv();
            k.Show();
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemhddv d = new frmTimkiemhddv();
            d.Show();
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkehddv q = new frmThongkehddv();
            q.Show();
        }

        private void cHỈNHSỬAHDTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChinhsuahdtp s = new frmChinhsuahdtp();
            s.Show();
        }

        private void tÌMKIẾMHDTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemhdtp f = new frmTimkiemhdtp();
            f.Show();
        }

        private void tHỐNGKÊHDTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkehdtp m = new frmThongkehdtp();
            m.Show();
        }

        private void cHỈNHSỬAHDTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChinhsuahdtt z = new frmChinhsuahdtt();
            z.Show();
        }

        private void tÌMKIẾMHDTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemhdtt i = new frmTimkiemhdtt();
            i.Show();
        }

        private void tHỐNGKÊHDTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkehdtt v = new frmThongkehdtt();
            v.Show();
        }
    }
}
