namespace BankSystem
{
    partial class RequestLoan
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
            this.group_employee = new System.Windows.Forms.GroupBox();
            this.combo_bank = new System.Windows.Forms.ComboBox();
            this.combo_branch = new System.Windows.Forms.ComboBox();
            this.label_branch = new System.Windows.Forms.Label();
            this.label_bank = new System.Windows.Forms.Label();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.button_requestLoan = new System.Windows.Forms.Button();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.group_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_employee
            // 
            this.group_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group_employee.Controls.Add(this.combo_bank);
            this.group_employee.Controls.Add(this.combo_branch);
            this.group_employee.Controls.Add(this.label_branch);
            this.group_employee.Controls.Add(this.label_bank);
            this.group_employee.Location = new System.Drawing.Point(12, 116);
            this.group_employee.Name = "group_employee";
            this.group_employee.Size = new System.Drawing.Size(300, 77);
            this.group_employee.TabIndex = 21;
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
            // text_amount
            // 
            this.text_amount.Location = new System.Drawing.Point(93, 30);
            this.text_amount.Name = "text_amount";
            this.text_amount.Size = new System.Drawing.Size(193, 23);
            this.text_amount.TabIndex = 25;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(27, 33);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(54, 15);
            this.label_amount.TabIndex = 24;
            this.label_amount.Text = "Amount:";
            // 
            // button_requestLoan
            // 
            this.button_requestLoan.Location = new System.Drawing.Point(237, 212);
            this.button_requestLoan.Name = "button_requestLoan";
            this.button_requestLoan.Size = new System.Drawing.Size(75, 23);
            this.button_requestLoan.TabIndex = 26;
            this.button_requestLoan.Text = "Place Request";
            this.button_requestLoan.UseVisualStyleBackColor = true;
            this.button_requestLoan.Click += new System.EventHandler(this.button_requestLoan_Click);
            // 
            // combo_type
            // 
            this.combo_type.AccessibleName = "";
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Items.AddRange(new object[] {
            "Industry",
            "Commercial",
            "Personal"});
            this.combo_type.Location = new System.Drawing.Point(96, 69);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(190, 23);
            this.combo_type.TabIndex = 28;
            // 
            // label_type
            // 
            this.label_type.AccessibleName = "";
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(27, 72);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 15);
            this.label_type.TabIndex = 27;
            this.label_type.Text = "Type:";
            // 
            // RequestLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 260);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_requestLoan);
            this.Controls.Add(this.text_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.group_employee);
            this.Name = "RequestLoan";
            this.Text = "Request Loan";
            this.Load += new System.EventHandler(this.RequestLoan_Load);
            this.group_employee.ResumeLayout(false);
            this.group_employee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox group_employee;
        private ComboBox combo_bank;
        private ComboBox combo_branch;
        private Label label_branch;
        private Label label_bank;
        private TextBox text_amount;
        private Label label_amount;
        private Button button_requestLoan;
        private ComboBox combo_type;
        private Label label_type;
    }
}