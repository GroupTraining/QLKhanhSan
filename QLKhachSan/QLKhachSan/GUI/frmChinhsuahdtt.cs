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
    }
}
