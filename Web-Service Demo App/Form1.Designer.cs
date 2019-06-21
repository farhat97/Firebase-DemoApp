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
            this.enterHrsBtn = new System.Windows.Forms.Button();
            this.retrieveHrsBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // enterHrsBtn
            // 
            this.enterHrsBtn.Location = new System.Drawing.Point(37, 69);
            this.enterHrsBtn.Name = "enterHrsBtn";
            this.enterHrsBtn.Size = new System.Drawing.Size(107, 31);
            this.enterHrsBtn.TabIndex = 13;
            this.enterHrsBtn.Text = "Enter Hours";
            this.enterHrsBtn.UseVisualStyleBackColor = true;
            this.enterHrsBtn.Click += new System.EventHandler(this.enterHrsBtn_Click);
            // 
            // retrieveHrsBtn
            // 
            this.retrieveHrsBtn.Location = new System.Drawing.Point(37, 151);
            this.retrieveHrsBtn.Name = "retrieveHrsBtn";
            this.retrieveHrsBtn.Size = new System.Drawing.Size(107, 32);
            this.retrieveHrsBtn.TabIndex = 14;
            this.retrieveHrsBtn.Text = "Retrieve Hours";
            this.retrieveHrsBtn.UseVisualStyleBackColor = true;
            this.retrieveHrsBtn.Click += new System.EventHandler(this.retrieveHrsBtn_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(163, 23);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(581, 391);
            this.panel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 426);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.retrieveHrsBtn);
            this.Controls.Add(this.enterHrsBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "7";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button enterHrsBtn;
        private System.Windows.Forms.Button retrieveHrsBtn;
        private System.Windows.Forms.Panel panel;
    }
}

