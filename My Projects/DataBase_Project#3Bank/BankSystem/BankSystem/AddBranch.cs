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
    public partial class Form_Branch : Form
    {
        private SqlConnection connection = new SqlConnection();

        public Form_Branch()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
        }
        private void Form_Branch_Load(object sender, EventArgs e)
        {
            connection.Open();
            String sql = "select Name from Bank";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                combo_bank.Items.Add(reader.GetString(0));

            }
            connection.Close(); 
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string sql;
            int code = -1;

            connection.Open();
            sql = "select Code from Bank where Name='"+combo_bank.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                code = reader.GetInt32(0);
            }
            reader.Close();
            sql = "insert into Branch (Code, Address) values ('"+code+"', '"+text_addr.Text+"')";
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            this.Close();
        }

    }
}
