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
    public partial class AddAccount : Form
    {
        private SqlConnection connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader reader;

        int SSN;

        public AddAccount()
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
        public AddAccount(int SSN) : this()
        {
            this.SSN = SSN;
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            connection.Open();

            sqlCommand.CommandText = "select Name from Bank";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) combo_bank.Items.Add(reader.GetString(0));
            reader.Close();

            connection.Close(); 
        }
        private void combo_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = -1;

            combo_branch.Items.Clear();
            connection.Open();

            sqlCommand.CommandText = "select Code from Bank where Name='"+combo_bank.Text+"'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) code = reader.GetInt32(0);
            reader.Close();

            sqlCommand.CommandText =  "select Address from Branch where Code='"+code+"'";
            reader = sqlCommand.ExecuteReader();
            while (reader.Read()) combo_branch.Items.Add(reader.GetString(0));

            connection.Close(); 
        }

        private void button_requestLoan_Click(object sender, EventArgs e)
        {

        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            int code = -1;
            int branch_number = -1;

            //get the code of the correspoiding bank name
            connection.Open();

            sqlCommand.CommandText = "select Code from Bank where Name='"+combo_bank.Text+"'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) code = reader.GetInt32(0);
            reader.Close();



            //get the Branch number correspoding to that bank with this address

            sqlCommand.CommandText = "select Branch_number from Branch where Address='"+combo_branch.Text+"' and Code='"+code+"'";
            reader = sqlCommand.ExecuteReader();
            while(reader.Read()) branch_number = reader.GetInt32(0);
            reader.Close();

            sqlCommand.CommandText = "insert into Account(SSN, Balance, Acctype, Branch_number, Code) values('"+SSN+"', '"+text_balance.Text+"', '"+combo_type.Text+"', '"+branch_number+"', '"+code+"')";
            sqlCommand.ExecuteNonQuery();

            connection.Close();
            
            this.Close();

        }
    }
}
