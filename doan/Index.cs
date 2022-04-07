using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void địaChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show(); 
        }
    }
}
