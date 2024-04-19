using DoctorsAptApp;

namespace DoctorsForms
{
    public partial class ScheduleForm : Form
    {

        private ScheduleLinkedList schedule;
    
         CreateApptPriorityQueue queue;
        public ScheduleForm(CreateApptPriorityQueue queue)
        {
            InitializeComponent();

            this.queue = queue;


            if (schedule == null)
            {
                schedule = new ScheduleLinkedList();
            }


            schedule.SchedulePatients(queue);

            scheduleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            scheduleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            

            PopulateSchedule();

        }

        private void PopulateSchedule()
        {
            //scheduleDataGridView.Rows.Clear();


            if (scheduleDataGridView.Columns.Count == 0)
            {
                scheduleDataGridView.Columns.Add("Name", "Name");
                scheduleDataGridView.Columns.Add("Age", "Age");
                scheduleDataGridView.Columns.Add("Severity", "Severity");
                scheduleDataGridView.Columns.Add("DateTime", "DateTime");
            }


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

        public void UpdateSchedule(CreateApptPriorityQueue newData)
        {

            schedule.SchedulePatients(newData);


            PopulateSchedule();
        }


        private void openPatientButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PatientForm form = new PatientForm();
            form.Show();
        }
    }
}
