using DoctorsAptApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorsForms
{
    public partial class ScheduleForm : Form
    {
        private CreateApptPriorityQueue queue;
        private ScheduleLinkedList schedule;
        public ScheduleForm(CreateApptPriorityQueue queue)
        {
            InitializeComponent();
            this.queue = queue;
            schedule = new ScheduleLinkedList();
            schedule.SchedulePatients(queue);


            scheduleDataGridView.Columns.Add("Name", "Name");
            scheduleDataGridView.Columns.Add("Age", "Age");
            scheduleDataGridView.Columns.Add("Severity", "Severity");
            scheduleDataGridView.Columns.Add("DateTime", "DateTime");


            foreach (Appointment appointment in schedule)
            {

                scheduleDataGridView.Rows.Add(
                    appointment.Patient.Name,
                    appointment.Patient.Age,
                    appointment.Patient.Severity,
                    appointment.Time.ToString("g")
                );
            }
        }
    }
}
