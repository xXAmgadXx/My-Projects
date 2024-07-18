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

namespace BankSystem
{
    public partial class AddCustomer : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;
        int employeeID;

        public AddCustomer()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
            sqlCommand.Connection = connection;
        }

        public AddCustomer(int employeeID) : this()
        {
            this.employeeID = employeeID;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int SSN = -1;
            if(String.IsNullOrEmpty(text_username.Text) || String.IsNullOrEmpty(text_password.Text))
            {
                MessageBox.Show("Invalid input you must enter username and password");
                return;
            }

            connection.Open();
            sqlCommand.CommandText = "insert into Customer (Name, username, password, Phone, Address) values('"+text_name.Text+"', '"+text_username.Text+"', '"+text_password.Text+"', '"+text_phone.Text+"', '"+text_addr.Text+"') ";
            sqlCommand.ExecuteNonQuery();


            sqlCommand.CommandText = "select SSN from Customer where username='" + text_username.Text + "' ";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) SSN = reader.GetInt32(0);
            reader.Close();


            //insert into EC a new customer relation
            sqlCommand.CommandText = "insert into EC (SSN, Em_ID) select '"+SSN+"', '"+employeeID+"' where not exists (select * from EC where SSN='"+SSN+"' and Em_ID='"+employeeID+"')";
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();

        }
    }
}
