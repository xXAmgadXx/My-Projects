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
    public partial class Form_Bank : Form
    {
        private SqlConnection connection = new SqlConnection();
        public Form_Bank()
        {
            InitializeComponent();

            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-T38CFA5\\MSSQLSERVER01";   // update me
            builder.UserID = "Bank";              // update me
            builder.InitialCatalog = "BankDB";

            connection.ConnectionString = builder.ConnectionString;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "insert into Bank (Name, Address) values ('"+text_bankName.Text+"', '"+text_addr.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
