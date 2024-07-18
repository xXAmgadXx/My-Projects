namespace BankSystem
{
    partial class Form_SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignIn = new System.Windows.Forms.GroupBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_role = new System.Windows.Forms.Label();
            this.radio_employee = new System.Windows.Forms.RadioButton();
            this.radio_customer = new System.Windows.Forms.RadioButton();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.SignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.Controls.Add(this.button_signup);
            this.SignIn.Controls.Add(this.label_role);
            this.SignIn.Controls.Add(this.radio_employee);
            this.SignIn.Controls.Add(this.radio_customer);
            this.SignIn.Controls.Add(this.text_password);
            this.SignIn.Controls.Add(this.text_username);
            this.SignIn.Controls.Add(this.button_submit);
            this.SignIn.Controls.Add(this.label_password);
            this.SignIn.Controls.Add(this.label_username);
            this.SignIn.Location = new System.Drawing.Point(12, 12);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(326, 213);
            this.SignIn.TabIndex = 0;
            this.SignIn.TabStop = false;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(94, 169);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(75, 23);
            this.button_signup.TabIndex = 13;
            this.button_signup.Text = "Register";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(23, 129);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(33, 15);
            this.label_role.TabIndex = 12;
            this.label_role.Text = "Role:";
            // 
            // radio_employee
            // 
            this.radio_employee.AutoSize = true;
            this.radio_employee.Checked = true;
            this.radio_employee.Location = new System.Drawing.Point(205, 127);
            this.radio_employee.Name = "radio_employee";
            this.radio_employee.Size = new System.Drawing.Size(77, 19);
            this.radio_employee.TabIndex = 11;
            this.radio_employee.TabStop = true;
            this.radio_employee.Text = "Employee";
            this.radio_employee.UseVisualStyleBackColor = true;
            // 
            // radio_customer
            // 
            this.radio_customer.AutoSize = true;
            this.radio_customer.Location = new System.Drawing.Point(92, 127);
            this.radio_customer.Name = "radio_customer";
            this.radio_customer.Size = new System.Drawing.Size(77, 19);
            this.radio_customer.TabIndex = 10;
            this.radio_customer.Text = "Customer";
            this.radio_customer.UseVisualStyleBackColor = true;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(92, 83);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(190, 23);
            this.text_password.TabIndex = 4;
            this.text_password.UseSystemPasswordChar = true;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(92, 35);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(190, 23);
            this.text_username.TabIndex = 3;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(207, 169);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Sign In";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(23, 86);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 15);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(23, 38);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 15);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // Form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 228);
            this.Controls.Add(this.SignIn);
            this.Name = "Form_SignIn";
            this.Text = "Sign In";
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SignIn;
        private TextBox text_password;
        private TextBox text_username;
        private Button button_submit;
        private Label label_password;
        private Label label_username;
        private Label label_role;
        private RadioButton radio_employee;
        private RadioButton radio_customer;
        private Button button_signup;
    }
}