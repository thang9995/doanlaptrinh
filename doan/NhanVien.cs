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
using System.Data.SqlClient;

namespace doan
{
    public partial class NhanVien : Form
    {    
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VHR2BC2;Initial Catalog=ManagerCar;User ID=sa;Password=123456");
        public SqlDataReader dr;
        public NhanVien()
        {
            InitializeComponent();
            
        }

        private void loadDistributor()
        {
            ManagerCarEntities2 db = new ManagerCarEntities2();
            cb_distributor.DataSource = db.distributor.ToList();
            cb_distributor.DisplayMember = "name";
            cb_distributor.ValueMember = "id";
        }

        private void loadCar()
        {
            ManagerCarEntities2 db = new ManagerCarEntities2();
            cb_car.DataSource = db.car.ToList();
            cb_car.DisplayMember = "name";
            cb_car.ValueMember = "id";
        }

        private void loadAddress()
        {
            DataTable tb = new DataTable("Address");
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                        "Select CONCAT(address_number, ',' ,ward,',',province,', ',district) AS full_address from Address", conn
                        );
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cb_address.DisplayMember = "full_address";
            cb_address.ValueMember = "id";
            cb_address.DataSource = tb;
            conn.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadAddress();
            loadCar();
            loadDistributor();
            this.LoadNhanvienList();
        }
        string id_selected;
        private void LoadNhanvienList()
        {
            ManagerCarEntities2 db = new ManagerCarEntities2();
            dgvdata.DataSource = db.staff.Select(
                    nv => new
                    {
                        nv.id,
                        nv.name,
                        nv.cart_number,
                        nv.salary,
                        distributor = nv.distributor.name,
                        car = nv.car.name,
                        address = nv.address.address_number + "/" + nv.address.ward + "/" + nv.address.district + "/" + nv.address.province ,
                    }
                ).ToList();
        }

        private void dgvdata_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 1)
            {
                id_selected = dgvdata.SelectedRows[0].Cells[0].Value.ToString();
                ManagerCarEntities2 db = new ManagerCarEntities2();
                staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
                txttenNv.Text = sf.name;
                txtCartNumber.Text = sf.cart_number;
                cb_address.SelectedValue = sf.addressId;
                cb_distributor.SelectedValue = sf.distributorId;
                Birthday.Text = sf.brithday.ToString();
                nud_salary.Value = sf.salary;
                cb_car.SelectedValue = sf.carId;
            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 dữ liệu");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string keyWork = txttimkiem.Text.Trim();
            ManagerCarEntities2 db = new ManagerCarEntities2();
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
            ManagerCarEntities2 db = new ManagerCarEntities2();
            staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
            sf.name = txttenNv.Text.Trim().ToString();
            sf.addressId = (int)cb_address.SelectedValue;
            sf.distributorId = (int)cb_address.SelectedValue;
            sf.brithday = Birthday.Value;
            sf.cart_number = txtCartNumber.Text.Trim().ToString();
            sf.carId = (int)cb_car.SelectedValue;
            sf.salary = (int)nud_salary.Value;
            db.Entry(sf).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("cập nhật thành công " + sf.name);
            this.LoadNhanvienList();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            ManagerCarEntities2 db = new ManagerCarEntities2();
            staff sf = db.staff.SingleOrDefault(sfs => sfs.id.ToString() == id_selected);
            db.staff.Remove(sf);
            db.SaveChanges();
            MessageBox.Show("xoá thành công " + sf.name);
            this.LoadNhanvienList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ManagerCarEntities2 db = new ManagerCarEntities2();
            staff sf = new staff();
            sf.name = txttenNv.Text.Trim();
            sf.brithday = Birthday.Value;
            sf.cart_number = txtCartNumber.Text.Trim();
            sf.salary = (int)nud_salary.Value;
            sf.carId = (int)cb_car.SelectedValue;
            sf.distributorId = (int)cb_distributor.SelectedValue;
            sf.addressId = (int)cb_address.SelectedValue;

            db.staff.Add(sf);
            db.SaveChanges();
            MessageBox.Show("thêm thành công " + sf.name);
            this.LoadNhanvienList();
        }

        private void cb_distributor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index id = new Index();
            id.Show();
        }
    }
}
