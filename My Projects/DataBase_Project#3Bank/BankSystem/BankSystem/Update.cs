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
    public partial class Form_Update : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;
        private int key;
        private bool ec;

        public Form_Update()
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
        public Form_Update(int key, bool ec) : this()       //bool ec (employee or customer) is true if employee and false if customer
        {
            this.key = key;
            this.ec = ec;
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string sql;
            if(String.IsNullOrEmpty(text_username.Text) || String.IsNullOrEmpty(text_password.Text))
            {
                MessageBox.Show("Invalid input you must enter username and password");
                return;
            }

            if (!ec) {
                sql = "update Customer set username='" + text_username.Text + "', password='" + text_password.Text + "', Phone='" + text_phone.Text + "', Address='" + text_addr.Text + "' ";
                sql += "where SSN='"+key+"'";
            }
            else {
                sql = "update Employee set username='" + text_username.Text + "', password='" + text_password.Text + "', Phone='" + text_phone.Text + "', Address='" + text_addr.Text + "' ";
                sql += "where Em_ID='"+key+"'";
            }

            connection.Open();
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

    }
}
