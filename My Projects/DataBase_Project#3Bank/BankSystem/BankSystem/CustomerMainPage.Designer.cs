namespace BankSystem
{
    partial class CustomerMainPage
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
            this.update = new System.Windows.Forms.Button();
            this.customer_addr = new System.Windows.Forms.Label();
            this.label_addr = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.button_requestLoan = new System.Windows.Forms.Button();
            this.button_loans = new System.Windows.Forms.Button();
            this.button_addAccount = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_operation = new System.Windows.Forms.Button();
            this.button_showAccounts = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(273, 97);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 31);
            this.update.TabIndex = 38;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // customer_addr
            // 
            this.customer_addr.AutoSize = true;
            this.customer_addr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customer_addr.Location = new System.Drawing.Point(85, 97);
            this.customer_addr.Name = "customer_addr";
            this.customer_addr.Size = new System.Drawing.Size(123, 20);
            this.customer_addr.TabIndex = 34;
            this.customer_addr.Text = "customerAddress";
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_addr.Location = new System.Drawing.Point(15, 97);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(65, 20);
            this.label_addr.TabIndex = 33;
            this.label_addr.Text = "Address:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(85, 59);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(51, 20);
            this.phone.TabIndex = 32;
            this.phone.Text = "phone";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_phone.Location = new System.Drawing.Point(15, 59);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(53, 20);
            this.label_phone.TabIndex = 31;
            this.label_phone.Text = "Phone:";
            // 
            // button_requestLoan
            // 
            this.button_requestLoan.Location = new System.Drawing.Point(273, 174);
            this.button_requestLoan.Name = "button_requestLoan";
            this.button_requestLoan.Size = new System.Drawing.Size(123, 31);
            this.button_requestLoan.TabIndex = 30;
            this.button_requestLoan.Text = "Request Loan";
            this.button_requestLoan.UseVisualStyleBackColor = true;
            this.button_requestLoan.Click += new System.EventHandler(this.button_requestLoan_Click);
            // 
            // button_loans
            // 
            this.button_loans.Location = new System.Drawing.Point(142, 172);
            this.button_loans.Name = "button_loans";
            this.button_loans.Size = new System.Drawing.Size(125, 31);
            this.button_loans.TabIndex = 29;
            this.button_loans.Text = "Show Loans";
            this.button_loans.UseVisualStyleBackColor = true;
            this.button_loans.Click += new System.EventHandler(this.button_loans_Click);
            // 
            // button_addAccount
            // 
            this.button_addAccount.Location = new System.Drawing.Point(27, 172);
            this.button_addAccount.Name = "button_addAccount";
            this.button_addAccount.Size = new System.Drawing.Size(109, 33);
            this.button_addAccount.TabIndex = 28;
            this.button_addAccount.Text = "Add Account";
            this.button_addAccount.UseVisualStyleBackColor = true;
            this.button_addAccount.Click += new System.EventHandler(this.button_addAccount_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(85, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 27;
            this.name.Text = "admin";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(16, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 20);
            this.label_name.TabIndex = 26;
            this.label_name.Text = "Name:";
            // 
            // button_operation
            // 
            this.button_operation.Location = new System.Drawing.Point(27, 213);
            this.button_operation.Name = "button_operation";
            this.button_operation.Size = new System.Drawing.Size(109, 31);
            this.button_operation.TabIndex = 36;
            this.button_operation.Text = "Start Operation";
            this.button_operation.UseVisualStyleBackColor = true;
            this.button_operation.Click += new System.EventHandler(this.button_operation_Click);
            // 
            // button_showAccounts
            // 
            this.button_showAccounts.Location = new System.Drawing.Point(142, 211);
            this.button_showAccounts.Name = "button_showAccounts";
            this.button_showAccounts.Size = new System.Drawing.Size(125, 33);
            this.button_showAccounts.TabIndex = 35;
            this.button_showAccounts.Text = "Show Accounts";
            this.button_showAccounts.UseVisualStyleBackColor = true;
            this.button_showAccounts.Click += new System.EventHandler(this.button_showAccounts_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(429, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(448, 248);
            this.dataGridView.TabIndex = 39;
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 264);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button_operation);
            this.Controls.Add(this.button_showAccounts);
            this.Controls.Add(this.customer_addr);
            this.Controls.Add(this.label_addr);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.button_requestLoan);
            this.Controls.Add(this.button_loans);
            this.Controls.Add(this.button_addAccount);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label_name);
            this.Name = "CustomerMainPage";
            this.Text = "CustomerMainPage";
            this.Load += new System.EventHandler(this.CustomerMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button update;
        private Label customer_addr;
        private Label label_addr;
        private Label phone;
        private Label label_phone;
        private Button button_requestLoan;
        private Button button_loans;
        private Button button_addAccount;
        private Label name;
        private Label label_name;
        private Button button_operation;
        private Button button_showAccounts;
        private DataGridView dataGridView;
    }
}