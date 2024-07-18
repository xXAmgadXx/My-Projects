namespace BankSystem
{
    partial class EmployeeMainPage
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.branch_addr = new System.Windows.Forms.Label();
            this.label_branch = new System.Windows.Forms.Label();
            this.bank_name = new System.Windows.Forms.Label();
            this.label_bank = new System.Windows.Forms.Label();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_loans = new System.Windows.Forms.Button();
            this.button_addCustomer = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(392, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(448, 248);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // branch_addr
            // 
            this.branch_addr.AutoSize = true;
            this.branch_addr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branch_addr.Location = new System.Drawing.Point(69, 119);
            this.branch_addr.Name = "branch_addr";
            this.branch_addr.Size = new System.Drawing.Size(107, 20);
            this.branch_addr.TabIndex = 20;
            this.branch_addr.Text = "branchAddress";
            // 
            // label_branch
            // 
            this.label_branch.AutoSize = true;
            this.label_branch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_branch.Location = new System.Drawing.Point(11, 119);
            this.label_branch.Name = "label_branch";
            this.label_branch.Size = new System.Drawing.Size(57, 20);
            this.label_branch.TabIndex = 19;
            this.label_branch.Text = "Branch:";
            // 
            // bank_name
            // 
            this.bank_name.AutoSize = true;
            this.bank_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bank_name.Location = new System.Drawing.Point(69, 81);
            this.bank_name.Name = "bank_name";
            this.bank_name.Size = new System.Drawing.Size(81, 20);
            this.bank_name.TabIndex = 18;
            this.bank_name.Text = "bankName";
            // 
            // label_bank
            // 
            this.label_bank.AutoSize = true;
            this.label_bank.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bank.Location = new System.Drawing.Point(11, 81);
            this.label_bank.Name = "label_bank";
            this.label_bank.Size = new System.Drawing.Size(44, 20);
            this.label_bank.TabIndex = 17;
            this.label_bank.Text = "Bank:";
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(257, 174);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(123, 31);
            this.button_customers.TabIndex = 16;
            this.button_customers.Text = "Show Customers";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_loans
            // 
            this.button_loans.Location = new System.Drawing.Point(126, 174);
            this.button_loans.Name = "button_loans";
            this.button_loans.Size = new System.Drawing.Size(125, 31);
            this.button_loans.TabIndex = 15;
            this.button_loans.Text = "Show Loans";
            this.button_loans.UseVisualStyleBackColor = true;
            this.button_loans.Click += new System.EventHandler(this.button_loans_Click);
            // 
            // button_addCustomer
            // 
            this.button_addCustomer.Location = new System.Drawing.Point(11, 174);
            this.button_addCustomer.Name = "button_addCustomer";
            this.button_addCustomer.Size = new System.Drawing.Size(109, 33);
            this.button_addCustomer.TabIndex = 13;
            this.button_addCustomer.Text = "Add Customer";
            this.button_addCustomer.UseVisualStyleBackColor = true;
            this.button_addCustomer.Click += new System.EventHandler(this.button_addCustomer_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(69, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 12;
            this.name.Text = "admin";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(11, 41);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 20);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Name:";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(258, 213);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(123, 31);
            this.button_pay.TabIndex = 24;
            this.button_pay.Text = "Pay Loan";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // button_reject
            // 
            this.button_reject.Location = new System.Drawing.Point(127, 213);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(125, 31);
            this.button_reject.TabIndex = 23;
            this.button_reject.Text = "Reject Loan";
            this.button_reject.UseVisualStyleBackColor = true;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(12, 213);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(109, 33);
            this.button_accept.TabIndex = 22;
            this.button_accept.Text = "Accept Loan";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(257, 115);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 31);
            this.update.TabIndex = 25;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // EmployeeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 278);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.branch_addr);
            this.Controls.Add(this.label_branch);
            this.Controls.Add(this.bank_name);
            this.Controls.Add(this.label_bank);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.button_loans);
            this.Controls.Add(this.button_addCustomer);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label_name);
            this.Name = "EmployeeMainPage";
            this.Text = "Employee Main Page";
            this.Load += new System.EventHandler(this.EmployeeMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private Label branch_addr;
        private Label label_branch;
        private Label bank_name;
        private Label label_bank;
        private Button button_customers;
        private Button button_loans;
        private Button button_addCustomer;
        private Label name;
        private Label label_name;
        private Button button_pay;
        private Button button_reject;
        private Button button_accept;
        private Button update;
    }
}