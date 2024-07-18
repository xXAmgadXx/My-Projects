namespace BankSystem
{
    partial class StartOperation
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
            this.text_balance = new System.Windows.Forms.TextBox();
            this.label_balance = new System.Windows.Forms.Label();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_widthdraw = new System.Windows.Forms.Button();
            this.combo_account = new System.Windows.Forms.ComboBox();
            this.label_account = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_balance
            // 
            this.text_balance.Location = new System.Drawing.Point(102, 27);
            this.text_balance.Name = "text_balance";
            this.text_balance.Size = new System.Drawing.Size(193, 23);
            this.text_balance.TabIndex = 33;
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(36, 30);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(51, 15);
            this.label_balance.TabIndex = 32;
            this.label_balance.Text = "Balance:";
            // 
            // button_deposit
            // 
            this.button_deposit.Location = new System.Drawing.Point(102, 105);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(75, 23);
            this.button_deposit.TabIndex = 34;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = true;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // button_widthdraw
            // 
            this.button_widthdraw.Location = new System.Drawing.Point(220, 105);
            this.button_widthdraw.Name = "button_widthdraw";
            this.button_widthdraw.Size = new System.Drawing.Size(75, 23);
            this.button_widthdraw.TabIndex = 35;
            this.button_widthdraw.Text = "Withdraw";
            this.button_widthdraw.UseVisualStyleBackColor = true;
            this.button_widthdraw.Click += new System.EventHandler(this.button_widthdraw_Click);
            // 
            // combo_account
            // 
            this.combo_account.AccessibleName = "";
            this.combo_account.FormattingEnabled = true;
            this.combo_account.Location = new System.Drawing.Point(102, 59);
            this.combo_account.Name = "combo_account";
            this.combo_account.Size = new System.Drawing.Size(193, 23);
            this.combo_account.TabIndex = 37;
            this.combo_account.SelectedIndexChanged += new System.EventHandler(this.combo_account_SelectedIndexChanged);
            // 
            // label_account
            // 
            this.label_account.AccessibleName = "";
            this.label_account.AutoSize = true;
            this.label_account.Location = new System.Drawing.Point(36, 65);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(55, 15);
            this.label_account.TabIndex = 36;
            this.label_account.Text = "Account:";
            // 
            // StartOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 140);
            this.Controls.Add(this.combo_account);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.button_widthdraw);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.text_balance);
            this.Controls.Add(this.label_balance);
            this.Name = "StartOperation";
            this.Text = "StartOperation";
            this.Load += new System.EventHandler(this.StartOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_balance;
        private Label label_balance;
        private Button button_deposit;
        private Button button_widthdraw;
        private ComboBox combo_account;
        private Label label_account;
    }
}