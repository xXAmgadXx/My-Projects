namespace BankSystem
{
    partial class Form_Bank
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
            this.Group_Bank = new System.Windows.Forms.GroupBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.text_bankName = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.label_bankName = new System.Windows.Forms.Label();
            this.Group_Bank.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_Bank
            // 
            this.Group_Bank.Controls.Add(this.button_submit);
            this.Group_Bank.Controls.Add(this.text_addr);
            this.Group_Bank.Controls.Add(this.text_bankName);
            this.Group_Bank.Controls.Add(this.label_addr);
            this.Group_Bank.Controls.Add(this.label_bankName);
            this.Group_Bank.Location = new System.Drawing.Point(12, 12);
            this.Group_Bank.Name = "Group_Bank";
            this.Group_Bank.Size = new System.Drawing.Size(288, 180);
            this.Group_Bank.TabIndex = 2;
            this.Group_Bank.TabStop = false;
            this.Group_Bank.Text = "Bank";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(195, 132);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Add";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // text_addr
            // 
            this.text_addr.Location = new System.Drawing.Point(76, 68);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(194, 23);
            this.text_addr.TabIndex = 3;
            // 
            // text_bankName
            // 
            this.text_bankName.Location = new System.Drawing.Point(76, 34);
            this.text_bankName.Name = "text_bankName";
            this.text_bankName.Size = new System.Drawing.Size(194, 23);
            this.text_bankName.TabIndex = 2;
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Location = new System.Drawing.Point(18, 71);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(52, 15);
            this.label_addr.TabIndex = 1;
            this.label_addr.Text = "Address:";
            // 
            // label_bankName
            // 
            this.label_bankName.AutoSize = true;
            this.label_bankName.Location = new System.Drawing.Point(18, 37);
            this.label_bankName.Name = "label_bankName";
            this.label_bankName.Size = new System.Drawing.Size(42, 15);
            this.label_bankName.TabIndex = 0;
            this.label_bankName.Text = "Name:";
            // 
            // Form_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 202);
            this.Controls.Add(this.Group_Bank);
            this.Name = "Form_Bank";
            this.Text = "Add New Bank";
            this.Group_Bank.ResumeLayout(false);
            this.Group_Bank.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Group_Bank;
        private TextBox text_addr;
        private TextBox text_bankName;
        private Label label_addr;
        private Label label_bankName;
        private Button button_submit;
    }
}