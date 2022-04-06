using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace doan
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            loadAddress();
            loadCar();
            loadDistributor();
        }

        private void loadDistributor()
        {
            ManagerCarEntities db = new ManagerCarEntities();
            cb_distributor.DataSource = db.distributor.ToList();
            cb_distributor.DisplayMember = "name";
            cb_distributor.ValueMember = "id";
        }

        private void loadCar()
        {
            ManagerCarEntities db = new ManagerCarEntities();
            cb_car.DataSource = db.car.ToList();
            cb_car.DisplayMember = "name";
            cb_distributor.ValueMember = "id";
        }

        private void loadAddress()
        {
            ManagerCarEntities db = new ManagerCarEntities();
            cb_car.DataSource = db.car.ToList();
            cb_car.DisplayMember = "district";
            cb_distributor.ValueMember = "id";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.LoadNhanvienList();
        }
        string id_selected;
        private void LoadNhanvienList()
        {
            ManagerCarEntities db = new ManagerCarEntities();
            dgvdata.DataSource = db.staff.Select(
                    nv => new
                    {
                        nv.id,
                        nv.name,
                        nv.cart_number,
                        nv.salary,
                        distributor = nv.distributor,
                        car = nv.car,
                        address = nv.address,
                    }
                ).ToList();
        }

        private void dgvdata_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 0)
            {
                id_selected = dgvdata.Rows[0].Cells[0].Value.ToString();
                ManagerCarEntities db = new ManagerCarEntities();
                staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
                txttenNv.Text = sf.name;
                txtCartNumber.Text = sf.cart_number;
                cb_address.SelectedValue = sf.addressId;
                cb_distributor.SelectedValue = sf.distributorId;
                Birthday.Text = sf.brithday.ToString();
                nud_salary.Value = sf.salary;
                cb_car.SelectedValue = sf.salary;
            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 dữ liệu");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string keyWork = txttimkiem.Text.Trim();
            ManagerCarEntities db = new ManagerCarEntities();
            dgvdata.DataSource = db.staff.Where(
                nv => nv.name.Contains(keyWork) || nv.cart_number.Contains(keyWork)
                ).ToList();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            this.LoadNhanvienList();
        }

        private void btnrep_Click(object sender, EventArgs e)
        {
            ManagerCarEntities db = new ManagerCarEntities();
            staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
            sf.name = txttenNv.Text.Trim();
            sf.addressId = (int)cb_address.SelectedValue;
            sf.distributorId = (int)cb_address.SelectedValue;
            sf.brithday = Birthday.Value;
            sf.cart_number = txtCartNumber.Text.Trim();
            sf.carId = (int)cb_car.SelectedValue;
            sf.salary = (int)nud_salary.Value;
            db.Entry(sf).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("cập nhật thành công " + sf.name);
            this.LoadNhanvienList();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            ManagerCarEntities db = new ManagerCarEntities();
            staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
            db.staff.Remove(sf);
            db.SaveChanges();
            MessageBox.Show("xoá thành công " + sf.name);
            this.LoadNhanvienList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ManagerCarEntities db = new ManagerCarEntities();
            staff sf = new staff();
            sf.name = txttenNv.Text.Trim();
            sf.brithday = Birthday.Value;
            sf.cart_number = txtCartNumber.Text.Trim();
            sf.salary = (int)nud_salary.Value;
            sf.carId = (int)cb_car.SelectedValue;
            sf.distributorId = (int)cb_distributor.SelectedValue;
            sf.addressId = (int)cb_address.SelectedValue;
        }
    }
}
