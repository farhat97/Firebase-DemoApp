using System;

namespace Web_Service_Demo_App
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.endTimeText = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(314, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Shift Manager";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(173, 125);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(196, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(173, 178);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(196, 20);
            this.idText.TabIndex = 3;
            this.idText.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(173, 227);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(196, 20);
            this.startTimeText.TabIndex = 4;
            // 
            // endTimeText
            // 
            this.endTimeText.Location = new System.Drawing.Point(173, 277);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.Size = new System.Drawing.Size(196, 20);
            this.endTimeText.TabIndex = 5;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(63, 128);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(91, 13);
            this.employeeNameLabel.TabIndex = 6;
            this.employeeNameLabel.Text = "Employee\'s Name";
            this.employeeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(63, 181);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(74, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Employee\'s ID";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(63, 230);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 8;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(63, 280);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 9;
            this.endTimeLabel.Text = "End Time";
            this.endTimeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(173, 330);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(294, 330);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dateTextLabel
            // 
            this.dateTextLabel.AutoSize = true;
            this.dateTextLabel.Location = new System.Drawing.Point(63, 81);
            this.dateTextLabel.Name = "dateTextLabel";
            this.dateTextLabel.Size = new System.Drawing.Size(30, 13);
            this.dateTextLabel.TabIndex = 12;
            this.dateTextLabel.Text = "Date";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(173, 78);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(196, 20);
            this.dateText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 426);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.dateTextLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.endTimeText);
            this.Controls.Add(this.startTimeText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Employee\'s Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.TextBox endTimeText;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.TextBox dateText;
    }
}

