namespace DoctorsForms
{
    partial class ScheduleForm
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
            scheduleDataGridView = new DataGridView();
            openPatientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // scheduleDataGridView
            // 
            scheduleDataGridView.AllowUserToAddRows = false;
            scheduleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleDataGridView.Location = new Point(0, 0);
            scheduleDataGridView.MinimumSize = new Size(0, 250);
            scheduleDataGridView.Name = "scheduleDataGridView";
            scheduleDataGridView.ReadOnly = true;
            scheduleDataGridView.Size = new Size(801, 368);
            scheduleDataGridView.TabIndex = 0;
            // 
            // openPatientButton
            // 
            openPatientButton.Anchor = AnchorStyles.Bottom;
            openPatientButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openPatientButton.Location = new Point(315, 374);
            openPatientButton.Name = "openPatientButton";
            openPatientButton.Size = new Size(117, 29);
            openPatientButton.TabIndex = 1;
            openPatientButton.Text = "Return to add";
            openPatientButton.UseVisualStyleBackColor = true;
            openPatientButton.Click += openPatientButton_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openPatientButton);
            Controls.Add(scheduleDataGridView);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView scheduleDataGridView;
        private Button openPatientButton;
    }
}