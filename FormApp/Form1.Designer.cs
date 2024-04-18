namespace FormApp
{
    partial class patientForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.severityLabel = new System.Windows.Forms.Label();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.severityTextbox = new System.Windows.Forms.TextBox();
            this.insuranceCheckbox = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(8, 45);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age";
            // 
            // severityLabel
            // 
            this.severityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.severityLabel.AutoSize = true;
            this.severityLabel.Location = new System.Drawing.Point(8, 82);
            this.severityLabel.Name = "severityLabel";
            this.severityLabel.Size = new System.Drawing.Size(45, 13);
            this.severityLabel.TabIndex = 2;
            this.severityLabel.Text = "Severity";
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.insuranceLabel.AutoSize = true;
            this.insuranceLabel.Location = new System.Drawing.Point(8, 129);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(54, 13);
            this.insuranceLabel.TabIndex = 3;
            this.insuranceLabel.Text = "Insurance";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextbox.Location = new System.Drawing.Point(100, 12);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(274, 20);
            this.nameTextbox.TabIndex = 4;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageTextbox.Location = new System.Drawing.Point(100, 45);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(274, 20);
            this.ageTextbox.TabIndex = 5;
            // 
            // severityTextbox
            // 
            this.severityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.severityTextbox.Location = new System.Drawing.Point(100, 82);
            this.severityTextbox.Name = "severityTextbox";
            this.severityTextbox.Size = new System.Drawing.Size(274, 20);
            this.severityTextbox.TabIndex = 6;
            // 
            // insuranceCheckbox
            // 
            this.insuranceCheckbox.AutoSize = true;
            this.insuranceCheckbox.Location = new System.Drawing.Point(100, 135);
            this.insuranceCheckbox.Name = "insuranceCheckbox";
            this.insuranceCheckbox.Size = new System.Drawing.Size(91, 17);
            this.insuranceCheckbox.TabIndex = 7;
            this.insuranceCheckbox.Text = "Check for yes";
            this.insuranceCheckbox.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 171);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 334);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.insuranceCheckbox);
            this.Controls.Add(this.severityTextbox);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.insuranceLabel);
            this.Controls.Add(this.severityLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "patientForm";
            this.Text = "Patient Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label severityLabel;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.TextBox severityTextbox;
        private System.Windows.Forms.CheckBox insuranceCheckbox;
        private System.Windows.Forms.Button submitButton;
    }
}

