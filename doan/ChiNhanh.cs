﻿using System;
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
    public partial class ChiNhanh : Form
    {
        public ChiNhanh()
        {
            InitializeComponent();
        }

        private void dgvdata_Click(object sender, EventArgs e)
        {

        }

        private void btnfind_Click(object sender, EventArgs e)
        {

        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.LoadChinhanhList();
        }

        private void btnrep_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            this.LoadChinhanhList();
        }

        private void LoadChinhanhList()
        {
            
        }
    }
}
