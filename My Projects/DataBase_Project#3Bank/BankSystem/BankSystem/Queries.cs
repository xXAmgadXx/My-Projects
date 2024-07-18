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
    public partial class Queries : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;

        public Queries()
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

        private void Queries_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            dataGridView5.DataSource = null;
            dataGridView6.DataSource = null;

            connection.Open();

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Branch_number with No Customers", typeof(int));

            sqlCommand.CommandText = " select top 1 Branch_number from Branch where Branch_number not in (select Branch_number from Account union select Branch_number from Loan)";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) dt1.Rows.Add(reader.GetInt32(0));
            reader.Close();


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Branch_no with No Employees", typeof(int));

            sqlCommand.CommandText = "select top 1 Branch_number from Branch where Branch_number not in (select Branch_number from Employee)";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) dt2.Rows.Add(reader.GetInt32(0));
            reader.Close();


            DataTable dt3 = new DataTable();
            dt3.Columns.Add("Employee ID with Max Loans", typeof(int));
            dt3.Columns.Add("Number of Loans", typeof(int));

            sqlCommand.CommandText = " select top 1 Em_ID, count(Em_ID) mycount from Loan group by Em_ID order by mycount desc";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) dt3.Rows.Add(reader.GetInt32(0), reader.GetInt32(1));
            reader.Close();

            DataTable dt4 = new DataTable();
            dt4.Columns.Add("Customer ID With Max Loans", typeof(int));
            dt4.Columns.Add("Number of Loans", typeof(int));

            sqlCommand.CommandText = " select top 1 SSN, count(SSN) mycount from Loan group by SSN order by mycount desc ";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) dt4.Rows.Add(reader.GetInt32(0), reader.GetInt32(1));
            reader.Close();


            DataTable dt5 = new DataTable();
            dt5.Columns.Add("Customer ID with No Loans", typeof(int));

            sqlCommand.CommandText = " select top 1 SSN from Customer where SSN not in (select SSN from Loan)";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) dt5.Rows.Add(reader.GetInt32(0));
            reader.Close();



            DataTable dt6 = new DataTable();
            dt6.Columns.Add("SSN", typeof(int));
            dt6.Columns.Add("Name", typeof(string));
            dt6.Columns.Add("Phone", typeof(string));
            dt6.Columns.Add("Address", typeof(string));
            dt6.Columns.Add("No. Of Employees", typeof(int));

            sqlCommand.CommandText = "select Customer.SSN, Customer.Name, Customer.Phone, Customer.Address, count(EC.SSN) as employeeCount from Customer left join EC on Customer.SSN=EC.SSN group by Customer.SSN, Customer.Name, Customer.Address, Customer.Phone";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
                dt6.Rows.Add( reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4) );
            reader.Close();

            connection.Close();


            dataGridView1.Rows.Clear();

            dataGridView1.DataSource = dt1;
            dataGridView2.DataSource = dt2;
            dataGridView3.DataSource = dt3;
            dataGridView4.DataSource = dt4;
            dataGridView5.DataSource = dt5;
            dataGridView6.DataSource = dt6;
        }
    }
}
