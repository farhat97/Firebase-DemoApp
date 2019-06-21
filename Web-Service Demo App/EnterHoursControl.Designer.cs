namespace Web_Service_Demo_App
{
    partial class EnterHoursControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameText = new System.Windows.Forms.TextBox();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.endTimeText = new System.Windows.Forms.TextBox();
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(127, 110);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(196, 20);
            this.nameText.TabIndex = 15;
            // 
            // dateTextLabel
            // 
            this.dateTextLabel.AutoSize = true;
            this.dateTextLabel.Location = new System.Drawing.Point(17, 164);
            this.dateTextLabel.Name = "dateTextLabel";
            this.dateTextLabel.Size = new System.Drawing.Size(30, 13);
            this.dateTextLabel.TabIndex = 25;
            this.dateTextLabel.Text = "Date";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(248, 315);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 21;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(127, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(17, 265);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 24;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(17, 215);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 23;
            this.startTimeLabel.Text = "Start Time";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(17, 68);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(74, 13);
            this.idLabel.TabIndex = 22;
            this.idLabel.Text = "Employee\'s ID";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(17, 113);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(91, 13);
            this.employeeNameLabel.TabIndex = 20;
            this.employeeNameLabel.Text = "Employee\'s Name";
            // 
            // endTimeText
            // 
            this.endTimeText.Location = new System.Drawing.Point(127, 262);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.Size = new System.Drawing.Size(196, 20);
            this.endTimeText.TabIndex = 18;
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(127, 212);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(196, 20);
            this.startTimeText.TabIndex = 17;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(127, 65);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(196, 20);
            this.idText.TabIndex = 14;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(127, 161);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(196, 20);
            this.dateText.TabIndex = 16;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(129, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 13);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Shift Manager";
            // 
            // EnterHoursControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameText);
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
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.titleLabel);
            this.Name = "EnterHoursControl";
            this.Size = new System.Drawing.Size(539, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox endTimeText;
        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label titleLabel;
    }
}
