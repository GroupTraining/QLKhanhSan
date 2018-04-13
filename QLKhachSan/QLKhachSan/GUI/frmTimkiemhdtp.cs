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
    public partial class frmTimkiemhdtp : Form
    {
        Bus bus = new Bus();
        public frmTimkiemhdtp()
        {
            InitializeComponent();
        }

        private void frmTimkiemhdtp_Load(object sender, EventArgs e)
        {
            dgvTimKiemHDTP.DataSource = bus.get_Hdtp();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
                dgvTimKiemHDTP.DataSource = bus.TimKiem_Hdtp(txtNTTTK.Text);
            

        }
    }
}
