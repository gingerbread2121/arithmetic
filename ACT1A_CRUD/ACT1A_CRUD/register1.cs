using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT1A_CRUD
{
    public partial class register1 : Form
    {
        private MySqlConnection connection;
        public register1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=francis01;username=root;password=;");
        }

        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            string username = txtUserName.Text.Trim();
            String password = txtPassword.Text;
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(name))

            {
                MessageBox.Show("Please enter " +
                    "both name, username and password");
            }
            try
            {
                // OPEN THE CONNECTION STRING
                connection.Open();
                // CREATE A STRING THAT WILL HANDLE QUERY
                string registerquery = "INSERT INTO francis01 (name, username, passsword) VALUES (@name, @username, @password)";
                //EXECUTE THE COMMAND LOGINQEURY

                MySqlCommand command = new MySqlCommand(registerquery, connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username",username);
                command.Parameters.AddWithValue("@password", password);

                //GET ROW COUNT
                int rowsffected = command.ExecuteNonQuery();
                if (rowsffected > 0)
                {
                    MessageBox.Show("Register Successfully!");
                    //Admin adminpage = new Admin();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                //CLOSE CONNECTION WHETHER THERE IS A ERROR OR NOT
                if (connection.State == System.Data.ConnectionState.Open)

                {
                    connection.Close();
                }
            }
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Clear();

            
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
