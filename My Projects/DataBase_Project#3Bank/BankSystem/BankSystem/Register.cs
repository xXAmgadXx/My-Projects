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
    public partial class Form_SignUp : Form
    {
        private SqlConnection connection = new SqlConnection();

        public Form_SignUp()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            connection.Open();
            String sql = "select Name from Bank";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                combo_bank.Items.Add(reader.GetString(0));

            }
            reader.Close();
            connection.Close(); 

        }

        private void combo_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            int code = -1;

            combo_branch.Items.Clear();
            connection.Open();

            sql = "select Code from Bank where Name='"+combo_bank.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                code = reader.GetInt32(0);
            }

            reader.Close();

            sql = "select Address from Branch where Code='"+code+"'";
            sqlCommand.CommandText =  sql;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                combo_branch.Items.Add(reader.GetString(0));
            }
            connection.Close(); 
        }


        private void radio_customer_CheckedChanged(object sender, EventArgs e)
        {
            group_employee.Visible = radio_employee.Checked;

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand sqlCommand = new SqlCommand();

            if (radio_customer.Checked) {
                sql = "insert into Customer (Name, username, password, Phone, Address) ";
                sql += "values('" + text_name.Text + "', '" + text_username.Text + "', '" + text_password.Text + "', '" + text_phone.Text + "', '" + text_addr.Text + "')";
            }
            else {
                int code = -1;
                int branch_number = -1;

                //get the code of the correspoiding bank name
                connection.Open();

                sql = "select Code from Bank where Name='"+combo_bank.Text+"'";
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = sql;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    code = reader.GetInt32(0);
                }
                reader.Close();
                connection.Close();


                //get the Branch number correspoding to that bank with this address
                connection.Open();

                sql = "select Branch_number from Branch where Address='"+combo_branch.Text+"' and Code='"+code+"'";
                sqlCommand.CommandText = sql;
                reader = sqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    branch_number = reader.GetInt32(0);
                }

                reader.Close();
                connection.Close();

                sql = "insert into Employee (Name, username, password, Phone, Address, Code, Branch_number) ";
                sql += "values('" + text_name.Text + "', '" + text_username.Text + "', '" + text_password.Text + "', '" + text_phone.Text + "', '" + text_addr.Text + "', '"+code+"', '"+branch_number+"')";
            }

            connection.Open();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
        

    }
}
