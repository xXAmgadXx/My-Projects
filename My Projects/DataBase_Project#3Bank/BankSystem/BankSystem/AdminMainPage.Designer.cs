namespace BankSystem
{
    partial class AdminMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button_addBank = new System.Windows.Forms.Button();
            this.button_addBranch = new System.Windows.Forms.Button();
            this.button_loans = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_queries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(62, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(120, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 1;
            this.name.Text = "admin";
            // 
            // button_addBank
            // 
            this.button_addBank.Location = new System.Drawing.Point(23, 167);
            this.button_addBank.Name = "button_addBank";
            this.button_addBank.Size = new System.Drawing.Size(91, 33);
            this.button_addBank.TabIndex = 2;
            this.button_addBank.Text = "Add Bank";
            this.button_addBank.UseVisualStyleBackColor = true;
            this.button_addBank.Click += new System.EventHandler(this.button_addBank_Click);
            // 
            // button_addBranch
            // 
            this.button_addBranch.Location = new System.Drawing.Point(140, 167);
            this.button_addBranch.Name = "button_addBranch";
            this.button_addBranch.Size = new System.Drawing.Size(109, 33);
            this.button_addBranch.TabIndex = 3;
            this.button_addBranch.Text = "Add Branch";
            this.button_addBranch.UseVisualStyleBackColor = true;
            this.button_addBranch.Click += new System.EventHandler(this.button_addBranch_Click);
            // 
            // button_loans
            // 
            this.button_loans.Location = new System.Drawing.Point(23, 206);
            this.button_loans.Name = "button_loans";
            this.button_loans.Size = new System.Drawing.Size(91, 31);
            this.button_loans.TabIndex = 4;
            this.button_loans.Text = "Show Loans";
            this.button_loans.UseVisualStyleBackColor = true;
            this.button_loans.Click += new System.EventHandler(this.button_loans_Click);
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(140, 206);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(109, 31);
            this.button_customers.TabIndex = 5;
            this.button_customers.Text = "Show Customers";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(330, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(500, 248);
            this.dataGridView.TabIndex = 10;
            // 
            // button_queries
            // 
            this.button_queries.Location = new System.Drawing.Point(80, 130);
            this.button_queries.Name = "button_queries";
            this.button_queries.Size = new System.Drawing.Size(91, 31);
            this.button_queries.TabIndex = 11;
            this.button_queries.Text = "Show Queries";
            this.button_queries.UseVisualStyleBackColor = true;
            this.button_queries.Click += new System.EventHandler(this.button_queries_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 264);
            this.Controls.Add(this.button_queries);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.button_loans);
            this.Controls.Add(this.button_addBranch);
            this.Controls.Add(this.button_addBank);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label_name);
            this.Name = "AdminMainPage";
            this.Text = "L";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Label name;
        private Button button_addBank;
        private Button button_addBranch;
        private Button button_loans;
        private Button button_customers;
        private DataGridView dataGridView;
        private Button button_queries;
    }
}