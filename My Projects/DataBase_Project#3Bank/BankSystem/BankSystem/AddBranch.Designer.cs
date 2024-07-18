namespace BankSystem
{
    partial class Form_Branch
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
            this.Group_Branch = new System.Windows.Forms.GroupBox();
            this.combo_bank = new System.Windows.Forms.ComboBox();
            this.label_bank = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.Group_Branch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_Branch
            // 
            this.Group_Branch.Controls.Add(this.combo_bank);
            this.Group_Branch.Controls.Add(this.label_bank);
            this.Group_Branch.Controls.Add(this.button_submit);
            this.Group_Branch.Controls.Add(this.text_addr);
            this.Group_Branch.Controls.Add(this.label_addr);
            this.Group_Branch.Location = new System.Drawing.Point(12, 12);
            this.Group_Branch.Name = "Group_Branch";
            this.Group_Branch.Size = new System.Drawing.Size(286, 166);
            this.Group_Branch.TabIndex = 3;
            this.Group_Branch.TabStop = false;
            this.Group_Branch.Text = "Branch";
            // 
            // combo_bank
            // 
            this.combo_bank.FormattingEnabled = true;
            this.combo_bank.Location = new System.Drawing.Point(85, 27);
            this.combo_bank.Name = "combo_bank";
            this.combo_bank.Size = new System.Drawing.Size(192, 23);
            this.combo_bank.TabIndex = 13;
            // 
            // label_bank
            // 
            this.label_bank.AutoSize = true;
            this.label_bank.Location = new System.Drawing.Point(18, 30);
            this.label_bank.Name = "label_bank";
            this.label_bank.Size = new System.Drawing.Size(36, 15);
            this.label_bank.TabIndex = 12;
            this.label_bank.Text = "Bank:";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(202, 122);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Add";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // text_addr
            // 
            this.text_addr.Location = new System.Drawing.Point(85, 68);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(192, 23);
            this.text_addr.TabIndex = 3;
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
            // Form_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 174);
            this.Controls.Add(this.Group_Branch);
            this.Name = "Form_Branch";
            this.Text = "Add New Branch";
            this.Load += new System.EventHandler(this.Form_Branch_Load);
            this.Group_Branch.ResumeLayout(false);
            this.Group_Branch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Group_Branch;
        private Button button_submit;
        private TextBox text_addr;
        private Label label_addr;
        private ComboBox combo_bank;
        private Label label_bank;
    }
}