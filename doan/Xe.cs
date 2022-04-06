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
    public partial class Xe : Form
    {
        public Xe()
        {
            InitializeComponent();
        }

        private void Xe_Load(object sender, EventArgs e)
        {
            this.LoadXeList();
        }
        private void LoadXeList()
        {
            ManagerCarEntities db = new ManagerCarEntities();
            car carDb = new car();
            distributor distributorDb = new distributor();   
            dgvdata.DataSource = db.car.Select(abc => new
            {
                abc.id,
                abc.name,
                abc.color,
                abc.year_created,
                abc.amount,
                abc.distributor,
                abc.created_at

            }
                ).ToList();
        }
        string id_selected;
        private void dgvdata_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 1)
            {

                id_selected = dgvdata.SelectedRows[0].Cells[0].Value.ToString();
                ManagerCarEntities db = new ManagerCarEntities();
                car carValue = db.car.SingleOrDefault(
                    xyz => xyz.id.ToString() == id_selected);
                txttenxe.Text = carValue.name;
                txtamount.Value = carValue.amount;
                // npp
                int distributor_id = (int)carValue.distributorId;
                date.Value = carValue.created_at;
                //txttimkiem.Text = carValue.
                txtmau.Text = carValue.color;
                txtnamsx.Value = carValue.year_created;
                
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {

        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.LoadXeList();
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

        private void txtnamsx_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
         
        private void txtnpp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
