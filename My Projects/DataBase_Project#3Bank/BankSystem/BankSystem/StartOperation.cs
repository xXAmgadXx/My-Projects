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
    public partial class StartOperation : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;

        int SSN;
        int account_number;
        public StartOperation()
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

        public StartOperation(int SSN) : this()
        {
            this.SSN = SSN;
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            int balance = -1;

            connection.Open();

            sqlCommand.CommandText = "select Balance from Account where Account_number='" + account_number + "'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read())  balance = reader.GetInt32(0);
            reader.Close();

            balance += Convert.ToInt32(text_balance.Text);

            sqlCommand.CommandText = "update Account set Balance='"+balance+"' where Account_number='" + account_number + "'";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
        }

        private void button_widthdraw_Click(object sender, EventArgs e)
        {
            int balance = -1;

            connection.Open();

            sqlCommand.CommandText = "select Balance from Account where Account_number='" + account_number + "'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read())  balance = reader.GetInt32(0);
            reader.Close();

            balance -= Convert.ToInt32(text_balance.Text);

            sqlCommand.CommandText = "update Account set Balance='"+balance+"' where Account_number='" + account_number + "'";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
        }

        private void StartOperation_Load(object sender, EventArgs e)
        {
            connection.Open();

            sqlCommand.CommandText = "select Account_number from Account where SSN='"+SSN+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) combo_account.Items.Add(reader.GetInt32(0));
            reader.Close();

            connection.Close(); 
        }

        private void combo_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            account_number = Convert.ToInt32(combo_account.Text);
        }
    }
}
