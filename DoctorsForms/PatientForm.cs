using DoctorsAptApp;

namespace DoctorsForms
{
    public partial class PatientForm : Form
    {
        public static CreateApptPriorityQueue queue;
        public static ScheduleForm scheduleForm;
        public PatientForm()
        {
            InitializeComponent();
            queue = CreateApptPriorityQueue.Instance;
            


        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            Patient patient = new();
            string message;
            try
            {
                var name = nameTextbox.Text;
                var age = int.Parse(ageTextbox.Text);
                var severity = int.Parse(severityTextbox.Text);
                var insurance = insuranceCheckbox.Checked;
                patient.Name = name;
                patient.Age = int.TryParse(ageTextbox.Text, out int value) ? value : 0;
                patient.Severity = severity;
                patient.Insurance = insurance;

                
                queue.AddPatient(patient);
                message = "Successfully added patient: ";
                message += patient.ToString() + "\nPatients in queue: " + queue.ToString();

            }
            catch (ArgumentNullException ex)
            {

                message = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                message = ex.Message;
            }

            catch (Exception)
            {
                message = "Name must a word\nAge and severity must be numbers";
            }


            MessageBox.Show(message);
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            if (scheduleForm == null || scheduleForm.IsDisposed)
            {
                scheduleForm = new ScheduleForm(queue);
                scheduleForm.FormClosed += (s, args) => this.Close();
            }

            AddDataToScheduleForm(queue);

            this.Hide();
            
            scheduleForm.Show();
        }

        private void AddDataToScheduleForm(CreateApptPriorityQueue newData)
        {
            if (scheduleForm != null && !scheduleForm.IsDisposed)
            {
                scheduleForm.UpdateSchedule(newData); 
            }
        }
    }
}
