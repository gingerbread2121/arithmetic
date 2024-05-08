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

    public partial class Admin : Form
    {
        private MySqlConnection connection;
        public Admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=francis01;username=root;password=;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load_1(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordquery = "SELECT ID, username, name, role FROME user ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        private void admin_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();  
                txtName.Text = row.Cells["name"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();   
            }

        }
    }
}
