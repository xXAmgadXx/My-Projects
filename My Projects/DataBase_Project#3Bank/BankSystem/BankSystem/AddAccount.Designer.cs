namespace BankSystem
{
    partial class AddAccount
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
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.button_addAccount = new System.Windows.Forms.Button();
            this.text_balance = new System.Windows.Forms.TextBox();
            this.label_balance = new System.Windows.Forms.Label();
            this.group_employee = new System.Windows.Forms.GroupBox();
            this.combo_bank = new System.Windows.Forms.ComboBox();
            this.combo_branch = new System.Windows.Forms.ComboBox();
            this.label_branch = new System.Windows.Forms.Label();
            this.label_bank = new System.Windows.Forms.Label();
            this.group_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_type
            // 
            this.combo_type.AccessibleName = "";
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Items.AddRange(new object[] {
            "Industry",
            "Commercial",
            "Personal"});
            this.combo_type.Location = new System.Drawing.Point(92, 66);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(190, 23);
            this.combo_type.TabIndex = 34;
            // 
            // label_type
            // 
            this.label_type.AccessibleName = "";
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(23, 69);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 15);
            this.label_type.TabIndex = 33;
            this.label_type.Text = "Type:";
            // 
            // button_addAccount
            // 
            this.button_addAccount.Location = new System.Drawing.Point(227, 201);
            this.button_addAccount.Name = "button_addAccount";
            this.button_addAccount.Size = new System.Drawing.Size(85, 23);
            this.button_addAccount.TabIndex = 32;
            this.button_addAccount.Text = "Add Account";
            this.button_addAccount.UseVisualStyleBackColor = true;
            this.button_addAccount.Click += new System.EventHandler(this.button_addAccount_Click);
            // 
            // text_balance
            // 
            this.text_balance.Location = new System.Drawing.Point(89, 27);
            this.text_balance.Name = "text_balance";
            this.text_balance.Size = new System.Drawing.Size(193, 23);
            this.text_balance.TabIndex = 31;
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(23, 30);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(51, 15);
            this.label_balance.TabIndex = 30;
            this.label_balance.Text = "Balance:";
            // 
            // group_employee
            // 
            this.group_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group_employee.Controls.Add(this.combo_bank);
            this.group_employee.Controls.Add(this.combo_branch);
            this.group_employee.Controls.Add(this.label_branch);
            this.group_employee.Controls.Add(this.label_bank);
            this.group_employee.Location = new System.Drawing.Point(12, 95);
            this.group_employee.Name = "group_employee";
            this.group_employee.Size = new System.Drawing.Size(300, 77);
            this.group_employee.TabIndex = 29;
            this.group_employee.TabStop = false;
            // 
            // combo_bank
            // 
            this.combo_bank.AccessibleName = "";
            this.combo_bank.FormattingEnabled = true;
            this.combo_bank.Location = new System.Drawing.Point(84, 13);
            this.combo_bank.Name = "combo_bank";
            this.combo_bank.Size = new System.Drawing.Size(190, 23);
            this.combo_bank.TabIndex = 13;
            this.combo_bank.SelectedIndexChanged += new System.EventHandler(this.combo_bank_SelectedIndexChanged);
            // 
            // combo_branch
            // 
            this.combo_branch.AccessibleName = "";
            this.combo_branch.FormattingEnabled = true;
            this.combo_branch.Location = new System.Drawing.Point(84, 48);
            this.combo_branch.Name = "combo_branch";
            this.combo_branch.Size = new System.Drawing.Size(190, 23);
            this.combo_branch.TabIndex = 15;
            // 
            // label_branch
            // 
            this.label_branch.AccessibleName = "";
            this.label_branch.AutoSize = true;
            this.label_branch.Location = new System.Drawing.Point(15, 51);
            this.label_branch.Name = "label_branch";
            this.label_branch.Size = new System.Drawing.Size(44, 15);
            this.label_branch.TabIndex = 14;
            this.label_branch.Text = "Branch";
            // 
            // label_bank
            // 
            this.label_bank.AccessibleName = "";
            this.label_bank.AutoSize = true;
            this.label_bank.Location = new System.Drawing.Point(15, 19);
            this.label_bank.Name = "label_bank";
            this.label_bank.Size = new System.Drawing.Size(36, 15);
            this.label_bank.TabIndex = 12;
            this.label_bank.Text = "Bank:";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 232);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_addAccount);
            this.Controls.Add(this.text_balance);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.group_employee);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.group_employee.ResumeLayout(false);
            this.group_employee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox combo_type;
        private Label label_type;
        private Button button_addAccount;
        private TextBox text_balance;
        private Label label_balance;
        private GroupBox group_employee;
        private ComboBox combo_bank;
        private ComboBox combo_branch;
        private Label label_branch;
        private Label label_bank;
    }
}