using System.Data.SqlClient;

namespace BankSystem
{
    public partial class Form_SignIn : Form
    {
        private SqlConnection connection = new SqlConnection();
        public Form_SignIn()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string sql = "";
            bool signed = false;

            connection.Open();
            if (radio_customer.Checked) 
                sql = "select * from Customer where username='" + text_username.Text + "' and password='"+text_password.Text+"'";
            else if(radio_employee.Checked)
                sql = "select * from Employee where username='" + text_username.Text + "' and password='"+text_password.Text+"'";

            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader =  sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (radio_employee.Checked)
                {
                    if (String.Equals(text_username.Text, "admin") && String.Equals(text_password.Text, "admin") )
                    {
                        signed = true;
                        //start admin main page
                        AdminMainPage admin = new AdminMainPage();
                        this.Hide();
                        admin.ShowDialog();
                        this.Show();
                    }
                    else if(String.Equals(text_username.Text, reader.GetString(4)) && String.Equals(text_password.Text, reader.GetString(3)) )
                    {
                        signed = true;
                        //start employee main page
                        EmployeeMainPage employee = new EmployeeMainPage(reader.GetInt32(2));
                        this.Hide();
                        employee.ShowDialog();
                        this.Show();
                    }
                }
                else if (radio_customer.Checked)
                {
                    //check if username and password are correct
                    if(String.Equals(text_username.Text, reader.GetString(4)) && String.Equals(text_password.Text, reader.GetString(5)))
                    {
                        signed = true;
                        //start customer main page
                        CustomerMainPage customerMainPage = new CustomerMainPage(reader.GetInt32(3));
                        this.Hide();
                        customerMainPage.ShowDialog();
                        this.Show();

                    }
                }
            }

            connection.Close();

            if (signed)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input incoreect username or password");
            }

        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            Form_SignUp signup = new Form_SignUp();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void SignIn_Enter(object sender, EventArgs e)
        {

        }
    }
}