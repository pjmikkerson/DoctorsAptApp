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
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // scheduleDataGridView
            // 
            scheduleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            scheduleDataGridView.Location = new Point(0, 0);
            scheduleDataGridView.Name = "scheduleDataGridView";
            scheduleDataGridView.Size = new Size(801, 327);
            scheduleDataGridView.TabIndex = 0;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scheduleDataGridView);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView scheduleDataGridView;
    }
}