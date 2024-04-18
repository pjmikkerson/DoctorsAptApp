namespace DoctorsForms
{
    partial class PatientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            ageLabel = new Label();
            label3 = new Label();
            insuranceLabel = new Label();
            severityTextbox = new TextBox();
            ageTextbox = new TextBox();
            nameTextbox = new TextBox();
            insuranceCheckbox = new CheckBox();
            addPatientButton = new Button();
            scheduleButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(25, 35);
            nameLabel.Margin = new Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(25, 100);
            ageLabel.Margin = new Padding(5, 0, 5, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(45, 25);
            ageLabel.TabIndex = 0;
            ageLabel.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 155);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 0;
            label3.Text = "Pain level(1-10)";
            // 
            // insuranceLabel
            // 
            insuranceLabel.AutoSize = true;
            insuranceLabel.Location = new Point(25, 218);
            insuranceLabel.Margin = new Padding(5, 0, 5, 0);
            insuranceLabel.Name = "insuranceLabel";
            insuranceLabel.Size = new Size(103, 25);
            insuranceLabel.TabIndex = 0;
            insuranceLabel.Text = "Insurance?";
            // 
            // severityTextbox
            // 
            severityTextbox.Location = new Point(253, 147);
            severityTextbox.Name = "severityTextbox";
            severityTextbox.Size = new Size(100, 33);
            severityTextbox.TabIndex = 3;
            // 
            // ageTextbox
            // 
            ageTextbox.Location = new Point(253, 92);
            ageTextbox.Name = "ageTextbox";
            ageTextbox.Size = new Size(100, 33);
            ageTextbox.TabIndex = 2;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(253, 27);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(100, 33);
            nameTextbox.TabIndex = 1;
            // 
            // insuranceCheckbox
            // 
            insuranceCheckbox.AutoSize = true;
            insuranceCheckbox.Location = new Point(253, 214);
            insuranceCheckbox.Name = "insuranceCheckbox";
            insuranceCheckbox.Size = new Size(58, 29);
            insuranceCheckbox.TabIndex = 4;
            insuranceCheckbox.Text = "yes";
            insuranceCheckbox.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            addPatientButton.Font = new Font("Segoe UI", 11.25F);
            addPatientButton.Location = new Point(25, 272);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(100, 37);
            addPatientButton.TabIndex = 5;
            addPatientButton.Text = "Add";
            addPatientButton.UseVisualStyleBackColor = true;
            addPatientButton.Click += submitButton_Click;
            // 
            // scheduleButton
            // 
            scheduleButton.Font = new Font("Segoe UI", 11.25F);
            scheduleButton.Location = new Point(253, 272);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(100, 52);
            scheduleButton.TabIndex = 6;
            scheduleButton.Text = "Create Schedule";
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Click += this.scheduleButton_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(scheduleButton);
            Controls.Add(addPatientButton);
            Controls.Add(insuranceCheckbox);
            Controls.Add(nameTextbox);
            Controls.Add(ageTextbox);
            Controls.Add(severityTextbox);
            Controls.Add(insuranceLabel);
            Controls.Add(label3);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "PatientForm";
            Text = "Patient Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label ageLabel;
        private Label label3;
        private Label insuranceLabel;
        private TextBox severityTextbox;
        private TextBox ageTextbox;
        private TextBox nameTextbox;
        private CheckBox insuranceCheckbox;
        private Button addPatientButton;
        private Button scheduleButton;
    }
}
