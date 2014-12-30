namespace ResultCalculationApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.physicsInputTextBox = new System.Windows.Forms.TextBox();
            this.chemistryInputTextBox = new System.Windows.Forms.TextBox();
            this.mathInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showAverageTextBox = new System.Windows.Forms.TextBox();
            this.showGradeLetterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemistry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Math";
            // 
            // physicsInputTextBox
            // 
            this.physicsInputTextBox.Location = new System.Drawing.Point(69, 32);
            this.physicsInputTextBox.Name = "physicsInputTextBox";
            this.physicsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.physicsInputTextBox.TabIndex = 3;
            // 
            // chemistryInputTextBox
            // 
            this.chemistryInputTextBox.Location = new System.Drawing.Point(69, 65);
            this.chemistryInputTextBox.Name = "chemistryInputTextBox";
            this.chemistryInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.chemistryInputTextBox.TabIndex = 4;
            // 
            // mathInputTextBox
            // 
            this.mathInputTextBox.Location = new System.Drawing.Point(69, 92);
            this.mathInputTextBox.Name = "mathInputTextBox";
            this.mathInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.mathInputTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "out of 100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "out of 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "out of 100";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(207, 145);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Grade Letter";
            // 
            // showAverageTextBox
            // 
            this.showAverageTextBox.Location = new System.Drawing.Point(84, 179);
            this.showAverageTextBox.Name = "showAverageTextBox";
            this.showAverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.showAverageTextBox.TabIndex = 12;
            // 
            // showGradeLetterTextBox
            // 
            this.showGradeLetterTextBox.Location = new System.Drawing.Point(84, 205);
            this.showGradeLetterTextBox.Name = "showGradeLetterTextBox";
            this.showGradeLetterTextBox.Size = new System.Drawing.Size(100, 20);
            this.showGradeLetterTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 336);
            this.Controls.Add(this.showGradeLetterTextBox);
            this.Controls.Add(this.showAverageTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mathInputTextBox);
            this.Controls.Add(this.chemistryInputTextBox);
            this.Controls.Add(this.physicsInputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox physicsInputTextBox;
        private System.Windows.Forms.TextBox chemistryInputTextBox;
        private System.Windows.Forms.TextBox mathInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox showAverageTextBox;
        private System.Windows.Forms.TextBox showGradeLetterTextBox;
    }
}

