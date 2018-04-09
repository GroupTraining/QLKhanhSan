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
    public partial class frmThemhdtt : Form
    {
        public static int x;
        Bus bus = new Bus();
        public frmThemhdtt()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            x  = bus.add_Hdtt(txtMahdtt.Text, txtMap.Text, txtMakhtt.Text, dtpN.Text, txtTien.Text, txtManv.Text);
        }
    }
}
