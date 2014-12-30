namespace BankAccountApp
{
    partial class BankAccountUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateEntryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showBalanceTextBox = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.openingDateShowTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberShowTextBox = new System.Windows.Forms.TextBox();
            this.emailShowTextBox = new System.Windows.Forms.TextBox();
            this.customerNameShowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.dateEntryTextBox);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.emailEntryTextBox);
            this.groupBox1.Controls.Add(this.customerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer & Account Info Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(172, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateEntryTextBox
            // 
            this.dateEntryTextBox.Location = new System.Drawing.Point(94, 138);
            this.dateEntryTextBox.Name = "dateEntryTextBox";
            this.dateEntryTextBox.Size = new System.Drawing.Size(153, 20);
            this.dateEntryTextBox.TabIndex = 7;
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(94, 101);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(153, 20);
            this.accountNumberEntryTextBox.TabIndex = 6;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(94, 65);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(153, 20);
            this.emailEntryTextBox.TabIndex = 5;
            // 
            // customerNameEntryTextBox
            // 
            this.customerNameEntryTextBox.Location = new System.Drawing.Point(94, 33);
            this.customerNameEntryTextBox.Name = "customerNameEntryTextBox";
            this.customerNameEntryTextBox.Size = new System.Drawing.Size(153, 20);
            this.customerNameEntryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.showBalanceTextBox);
            this.groupBox2.Controls.Add(this.Balance);
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Controls.Add(this.openingDateShowTextBox);
            this.groupBox2.Controls.Add(this.accountNumberShowTextBox);
            this.groupBox2.Controls.Add(this.emailShowTextBox);
            this.groupBox2.Controls.Add(this.customerNameShowTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(351, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer & Account Info";
            // 
            // showBalanceTextBox
            // 
            this.showBalanceTextBox.Location = new System.Drawing.Point(103, 211);
            this.showBalanceTextBox.Name = "showBalanceTextBox";
            this.showBalanceTextBox.Size = new System.Drawing.Size(153, 20);
            this.showBalanceTextBox.TabIndex = 10;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(51, 214);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 13);
            this.Balance.TabIndex = 9;
            this.Balance.Text = "Balance";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(181, 30);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(140, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Me Details";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // openingDateShowTextBox
            // 
            this.openingDateShowTextBox.Location = new System.Drawing.Point(103, 179);
            this.openingDateShowTextBox.Name = "openingDateShowTextBox";
            this.openingDateShowTextBox.Size = new System.Drawing.Size(153, 20);
            this.openingDateShowTextBox.TabIndex = 7;
            // 
            // accountNumberShowTextBox
            // 
            this.accountNumberShowTextBox.Location = new System.Drawing.Point(103, 150);
            this.accountNumberShowTextBox.Name = "accountNumberShowTextBox";
            this.accountNumberShowTextBox.Size = new System.Drawing.Size(153, 20);
            this.accountNumberShowTextBox.TabIndex = 6;
            // 
            // emailShowTextBox
            // 
            this.emailShowTextBox.Location = new System.Drawing.Point(103, 114);
            this.emailShowTextBox.Name = "emailShowTextBox";
            this.emailShowTextBox.Size = new System.Drawing.Size(153, 20);
            this.emailShowTextBox.TabIndex = 5;
            // 
            // customerNameShowTextBox
            // 
            this.customerNameShowTextBox.Location = new System.Drawing.Point(103, 78);
            this.customerNameShowTextBox.Name = "customerNameShowTextBox";
            this.customerNameShowTextBox.Size = new System.Drawing.Size(153, 20);
            this.customerNameShowTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Opening Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawButton);
            this.groupBox3.Controls.Add(this.depositButton);
            this.groupBox3.Controls.Add(this.amountTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(29, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 114);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(185, 85);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(185, 56);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(94, 26);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(153, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(88, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 34);
            this.label10.TabIndex = 11;
            this.label10.Text = "First Banking Solution";
            // 
            // BankAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAccountUI";
            this.Text = "BankAccountUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox dateEntryTextBox;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.TextBox customerNameEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox showBalanceTextBox;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox openingDateShowTextBox;
        private System.Windows.Forms.TextBox accountNumberShowTextBox;
        private System.Windows.Forms.TextBox emailShowTextBox;
        private System.Windows.Forms.TextBox customerNameShowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

