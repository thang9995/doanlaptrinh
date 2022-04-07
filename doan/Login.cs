using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace doan
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-VHR2BC2;Initial Catalog=ManagerCar;User ID=sa;Password=123456");
            conn.Open();
            tb_pass.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "" || tb_pass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào tên đăng nhập và password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        "Select * from Admin where name=@name and password=@password", conn
                        );
                    SqlDataReader sdr;
                    cmd.Parameters.AddWithValue("@name", tb_name.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", tb_pass.Text.ToString());
                    sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        sdr.Close();
                        MessageBox.Show("Xin Chào Admin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Index().Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Email or Password không đúng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_pass.Clear();
                    }
                    sdr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
