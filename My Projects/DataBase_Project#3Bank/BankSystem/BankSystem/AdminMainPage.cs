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
    public partial class AdminMainPage : Form
    {
        private SqlConnection connection = new SqlConnection();

        public AdminMainPage()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
        }

        private void button_addBank_Click(object sender, EventArgs e)
        {
            Form_Bank bank = new Form_Bank();
            this.Hide();
            bank.ShowDialog();
            this.Show();
        }

        private void button_addBranch_Click(object sender, EventArgs e)
        {
            Form_Branch branch = new Form_Branch();
            this.Hide();
            branch.ShowDialog();
            this.Show();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Address", typeof(string));

            connection.Open();
            String sql = "select SSN, Name, Phone, Address from Customer";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }
            reader.Close();
            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;
        }

        private void button_loans_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Em_ID", typeof(int));
            dt.Columns.Add("Loan_number", typeof(int));
            dt.Columns.Add("Loan_amount", typeof(int));
            dt.Columns.Add("Loan_type", typeof(string));

            connection.Open();
            String sql = "select SSN, Em_ID, Loan_number, Loan_amount, Loan_type from Loan";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4));
            }
            reader.Close();
            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;

        }

        private void button_queries_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            this.Hide();
            queries.ShowDialog();
            this.Show();
        }
    }
}
