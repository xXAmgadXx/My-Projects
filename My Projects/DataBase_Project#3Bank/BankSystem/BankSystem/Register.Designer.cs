namespace BankSystem
{
    partial class Form_SignUp
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.radio_customer = new System.Windows.Forms.RadioButton();
            this.radio_employee = new System.Windows.Forms.RadioButton();
            this.label_role = new System.Windows.Forms.Label();
            this.label_addr = new System.Windows.Forms.Label();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.group_register = new System.Windows.Forms.GroupBox();
            this.label_bank = new System.Windows.Forms.Label();
            this.label_branch = new System.Windows.Forms.Label();
            this.combo_branch = new System.Windows.Forms.ComboBox();
            this.combo_bank = new System.Windows.Forms.ComboBox();
            this.group_employee = new System.Windows.Forms.GroupBox();
            this.group_register.SuspendLayout();
            this.group_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(27, 78);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 15);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(25, 121);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 15);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(213, 356);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Register";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(94, 78);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(190, 23);
            this.text_username.TabIndex = 3;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(94, 118);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(190, 23);
            this.text_password.TabIndex = 4;
            this.text_password.UseSystemPasswordChar = true;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(28, 37);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(42, 15);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Name:";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(94, 34);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(190, 23);
            this.text_name.TabIndex = 6;
            // 
            // radio_customer
            // 
            this.radio_customer.AutoSize = true;
            this.radio_customer.Checked = true;
            this.radio_customer.Location = new System.Drawing.Point(94, 240);
            this.radio_customer.Name = "radio_customer";
            this.radio_customer.Size = new System.Drawing.Size(77, 19);
            this.radio_customer.TabIndex = 7;
            this.radio_customer.TabStop = true;
            this.radio_customer.Text = "Customer";
            this.radio_customer.UseVisualStyleBackColor = true;
            this.radio_customer.CheckedChanged += new System.EventHandler(this.radio_customer_CheckedChanged);
            // 
            // radio_employee
            // 
            this.radio_employee.AutoSize = true;
            this.radio_employee.Location = new System.Drawing.Point(207, 242);
            this.radio_employee.Name = "radio_employee";
            this.radio_employee.Size = new System.Drawing.Size(77, 19);
            this.radio_employee.TabIndex = 8;
            this.radio_employee.Text = "Employee";
            this.radio_employee.UseVisualStyleBackColor = true;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(25, 242);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(33, 15);
            this.label_role.TabIndex = 9;
            this.label_role.Text = "Role:";
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Location = new System.Drawing.Point(27, 203);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(52, 15);
            this.label_addr.TabIndex = 16;
            this.label_addr.Text = "Address:";
            // 
            // text_addr
            // 
            this.text_addr.Location = new System.Drawing.Point(94, 203);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(190, 23);
            this.text_addr.TabIndex = 17;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(25, 162);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(44, 15);
            this.label_phone.TabIndex = 18;
            this.label_phone.Text = "Phone:";
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(94, 159);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(190, 23);
            this.text_phone.TabIndex = 19;
            // 
            // group_register
            // 
            this.group_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group_register.Controls.Add(this.text_phone);
            this.group_register.Controls.Add(this.label_phone);
            this.group_register.Controls.Add(this.text_addr);
            this.group_register.Controls.Add(this.label_addr);
            this.group_register.Controls.Add(this.label_role);
            this.group_register.Controls.Add(this.radio_employee);
            this.group_register.Controls.Add(this.radio_customer);
            this.group_register.Controls.Add(this.text_name);
            this.group_register.Controls.Add(this.label_Name);
            this.group_register.Controls.Add(this.text_password);
            this.group_register.Controls.Add(this.text_username);
            this.group_register.Controls.Add(this.button_submit);
            this.group_register.Controls.Add(this.label_password);
            this.group_register.Controls.Add(this.label_username);
            this.group_register.Controls.Add(this.group_employee);
            this.group_register.Location = new System.Drawing.Point(23, 2);
            this.group_register.Name = "group_register";
            this.group_register.Size = new System.Drawing.Size(329, 400);
            this.group_register.TabIndex = 1;
            this.group_register.TabStop = false;
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
            // combo_branch
            // 
            this.combo_branch.AccessibleName = "";
            this.combo_branch.FormattingEnabled = true;
            this.combo_branch.Location = new System.Drawing.Point(84, 48);
            this.combo_branch.Name = "combo_branch";
            this.combo_branch.Size = new System.Drawing.Size(190, 23);
            this.combo_branch.TabIndex = 15;
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
            // group_employee
            // 
            this.group_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group_employee.Controls.Add(this.combo_bank);
            this.group_employee.Controls.Add(this.combo_branch);
            this.group_employee.Controls.Add(this.label_branch);
            this.group_employee.Controls.Add(this.label_bank);
            this.group_employee.Location = new System.Drawing.Point(6, 273);
            this.group_employee.Name = "group_employee";
            this.group_employee.Size = new System.Drawing.Size(300, 77);
            this.group_employee.TabIndex = 20;
            this.group_employee.TabStop = false;
            this.group_employee.Visible = false;
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 414);
            this.Controls.Add(this.group_register);
            this.Name = "Form_SignUp";
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            this.group_register.ResumeLayout(false);
            this.group_register.PerformLayout();
            this.group_employee.ResumeLayout(false);
            this.group_employee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_username;
        private Label label_password;
        private Button button_submit;
        private TextBox text_username;
        private TextBox text_password;
        private Label label_Name;
        private TextBox text_name;
        private RadioButton radio_customer;
        private RadioButton radio_employee;
        private Label label_role;
        private Label label_addr;
        private TextBox text_addr;
        private Label label_phone;
        private TextBox text_phone;
        private GroupBox group_register;
        private GroupBox group_employee;
        private ComboBox combo_bank;
        private ComboBox combo_branch;
        private Label label_branch;
        private Label label_bank;
    }
}