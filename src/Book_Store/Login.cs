using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Store
{
    public partial class Login : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123");
        public Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Application.DoEvents();
            connection.Open();
            string query = "SELECT * FROM Customers where Email = @m AND Password = @p";
            SqlCommand comm = new SqlCommand(query, connection);
            comm.Parameters.AddWithValue("@m", txtEmail.Text);
            comm.Parameters.AddWithValue("@p", txtPassword.Text);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                Customer customer = new Customer
                {
                    customerID = Convert.ToInt32(dr["Id"]),
                    customerEmail = dr["Email"].ToString(),
                    customerAddress = dr["Address"].ToString(),
                    customerPassword = dr["Password"].ToString(),
                    customerName = dr["Name"].ToString()
                };
                
                pictureBox2.Visible = false;
                CustomerManager.CreateAsSingleton().User = customer;
                LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
                Hide();
                Dashboard form = new Dashboard();
                form.ShowDialog();
                Dispose();
            }

            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            pictureBox2.Visible = false;
            connection.Close();


        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                checkShow.Text = "Show";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                checkShow.Text = "Hide";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
