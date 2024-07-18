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
    public partial class CustomerMainPage : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;

        int SSN;
        string customerName;
        string phoneNumber;
        string addr;
        
        public CustomerMainPage()
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
        
        public CustomerMainPage(int SSN) : this()
        {
            this.SSN = SSN;

            connection.Open();

            sqlCommand.CommandText = "select Name, Address, Phone from Customer where SSN='"+SSN+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                customerName = reader.GetString(0);
                addr = reader.GetString(1);
                phoneNumber = reader.GetString(2);
            }
            reader.Close();

            connection.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form_Update update = new Form_Update(SSN, false);
            this.Hide();
            update.ShowDialog();
            this.Show();
        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {
            name.Text = customerName;
            phone.Text = addr;
            customer_addr.Text = phoneNumber;
        }

        private void button_loans_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Loan_number", typeof(int));
            dt.Columns.Add("Loan_amount", typeof(int));
            dt.Columns.Add("Loan_type", typeof(string));
            dt.Columns.Add("Pending", typeof(int));
            dt.Columns.Add("Paid", typeof(int));

            connection.Open();
            String sql = "select SSN, Loan_number, Loan_amount, Loan_type, Pending, Paid from Loan where SSN='"+SSN+"'";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5) );
            }
            reader.Close();
            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;
        }

        private void button_showAccounts_Click(object sender, EventArgs e)
        {
            int code = -1, branch_number = -1;
            string bankName = "", branchAddr = "";
            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Balance", typeof(int));
            dt.Columns.Add("Account Number", typeof(int));
            dt.Columns.Add("Bank", typeof(string));
            dt.Columns.Add("Branch", typeof(string));

            connection.Open();


            sqlCommand.CommandText = "select Code, Branch_number from Account where SSN='"+SSN+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                code = reader.GetInt32(0);
                branch_number = reader.GetInt32(1);
            }
            reader.Close();

            sqlCommand.CommandText = "select Name from Bank where Code='" + code + "'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) bankName = reader.GetString(0);
            reader.Close();

            sqlCommand.CommandText = "select Address from Branch where Branch_number='" + branch_number + "'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) branchAddr = reader.GetString(0);
            reader.Close();


            sqlCommand.CommandText = "select SSN, Balance, Account_number from Account where SSN='"+SSN+"'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read())
                dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), bankName, branchAddr);
            reader.Close();

            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;

        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            AddAccount account = new AddAccount(SSN);
            this.Hide();
            account.ShowDialog();
            this.Show();
        }

        private void button_requestLoan_Click(object sender, EventArgs e)
        {
            RequestLoan loan = new RequestLoan(SSN);
            this.Hide();
            loan.ShowDialog();
            this.Show();
        }

        private void button_operation_Click(object sender, EventArgs e)
        {
            StartOperation op = new StartOperation(SSN);
            this.Hide();
            op.ShowDialog();
            this.Show();
        }
    }
}
