using MySql.Data.MySqlClient;
namespace ACT1A_CRUD
{
    public partial class Form1 : Form
    {
        //Declare MySqlConnection for handling database connection
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=francis01;username=root;password=;");
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // SANITIZED DATA TO REMOVE WHITE-SPACE
            string username = txtUsername.Text.Trim();
            String password = txtPassword.Text;

            // CHECK USERNAME AND PASSWORD ARE NOT EMPTY
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))

            {
                MessageBox.Show("Please enter " +
                    "both username and password");
            }

            try
            {
                // OPEN THE CONNECTION STRING
                connection.Open();
                // CREATE A STRING THAT WILL HANDLE QUERY
                string loginquary = "SELECT COUNT(*) FROM francis01 WHERE username = @username AND password = @password";
                //EXECUTE THE COMMAND LOGINQEURY

                MySqlCommand command = new MySqlCommand(loginquary, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                //GET ROW COUNT
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Correct username and password");
                    //Admin adminpage = new Admin();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register1 signuppage = new register1();
            signuppage.Show();
            this.Hide();
        }
    }
}
