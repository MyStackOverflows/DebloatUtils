namespace DebloatUtils
{
    partial class BugReportForm
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
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(12, 51);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.Size = new System.Drawing.Size(292, 96);
            this.ReportTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your name and a detailed bug report here:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(209, 153);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 34);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send report";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 153);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 34);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(292, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // BugReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 199);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 238);
            this.MinimumSize = new System.Drawing.Size(332, 238);
            this.Name = "BugReportForm";
            this.Text = "Send a bug report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}