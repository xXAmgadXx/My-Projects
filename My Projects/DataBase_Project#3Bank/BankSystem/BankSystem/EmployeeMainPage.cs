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
    public partial class EmployeeMainPage : Form
    {
        private SqlConnection connection = new SqlConnection();
        private string employeeName = "";
        private string bankName = "";
        private string branchAddr = "";
        private int loanNumber;
        private int SSN;
        private int employeeID;
        private bool customerButtonClicked;
        private bool loanButtonClicked;

        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;

        public EmployeeMainPage()
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
        public EmployeeMainPage(int Em_ID) : this()
        {
            employeeID = Em_ID;
            int code = -1;

            connection.Open();

            sqlCommand.CommandText = "select Code from Employee where Em_ID='"+Em_ID+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())  code = reader.GetInt32(0);
            reader.Close();

            sqlCommand.CommandText = "select Name from Employee where Em_ID='"+Em_ID+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) employeeName = reader.GetString(0);
            reader.Close();

            sqlCommand.CommandText = "select Name from Bank where Code='"+code+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) bankName = reader.GetString(0);
            reader.Close();

            sqlCommand.CommandText = "select Address from Branch where Code='"+code+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) branchAddr = reader.GetString(0);
            reader.Close();

            connection.Close();
        }

        private void EmployeeMainPage_Load(object sender, EventArgs e)
        {
            name.Text = employeeName;
            bank_name.Text = bankName;
            branch_addr.Text = branchAddr;
        }

        private void button_loans_Click(object sender, EventArgs e)
        {
            customerButtonClicked = false;
            loanButtonClicked = true;

            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Em_ID", typeof(int));
            dt.Columns.Add("Loan_number", typeof(int));
            dt.Columns.Add("Loan_amount", typeof(int));
            dt.Columns.Add("Loan_type", typeof(string));
            dt.Columns.Add("Pending", typeof(int));
            dt.Columns.Add("Paid", typeof(int));

            connection.Open();
            String sql = "select SSN, Em_ID, Loan_number, Loan_amount, Loan_type, Pending, Paid from Loan where Pending=1 or Paid=0";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6) );
            }
            reader.Close();
            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (loanButtonClicked)
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    loanNumber = (int)row.Cells[2].Value;
                    SSN = (int)row.Cells[0].Value;
                }
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            connection.Open();

            //change the pedning state to 0 to show it's accepted
            sqlCommand.CommandText = "update Loan set Pending=0 where Loan_number='"+loanNumber+"'";
            sqlCommand.ExecuteNonQuery();

            //change the Em_ID to the current employee ID
            sqlCommand.CommandText = "update Loan set Em_ID='"+employeeID+"' where Loan_number='"+loanNumber+"'";
            sqlCommand.ExecuteNonQuery();

            //insert into EC a new customer relation
            sqlCommand.CommandText = "insert into EC (SSN, Em_ID) select '"+SSN+"', '"+employeeID+"' where not exists (select * from EC where SSN='"+SSN+"' and Em_ID='"+employeeID+"')";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
        
        }

        private void button_reject_Click(object sender, EventArgs e)
        {
            connection.Open();

            //just delete the loan
            sqlCommand.CommandText = "delete from Loan where Loan_number='"+loanNumber+"'";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            customerButtonClicked = true;
            loanButtonClicked = false;
            dataGridView.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("SSN", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Address", typeof(string));

            connection.Open();

            sqlCommand.CommandText = "select SSN, Name, Phone, Address from Customer where SSN in (select SSN From EC where Em_ID='" + employeeID + "')";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) );
            }
            reader.Close();
            connection.Close(); 

            dataGridView.Rows.Clear();
            dataGridView.DataSource = dt;

        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            connection.Open();

            //change the pedning state to 0 to show it's accepted
            sqlCommand.CommandText = "update Loan set Paid=1 where Loan_number='"+loanNumber+"'";
            sqlCommand.ExecuteNonQuery();

            //change the Em_ID to the current employee ID
            sqlCommand.CommandText = "update Loan set Em_ID='"+employeeID+"' where Loan_number='"+loanNumber+"'";
            sqlCommand.ExecuteNonQuery();

            //insert into EC a new customer relation
            sqlCommand.CommandText = "insert into EC (SSN, Em_ID) select '"+SSN+"', '"+employeeID+"' where not exists (select * from EC where SSN='"+SSN+"' and Em_ID='"+employeeID+"')";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
        

        }

        private void update_Click(object sender, EventArgs e)
        {
            Form_Update update = new Form_Update(employeeID, true);
            this.Hide();
            update.ShowDialog();
            this.Show();
        }

        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer(employeeID);
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }
    }
}
