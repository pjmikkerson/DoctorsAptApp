using DoctorsAptApp;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace DoctorsForms
{
    public partial class PatientForm : Form
    {
        public CreateApptPriorityQueue queue;
        public ScheduleForm scheduleForm;
        public PatientForm()
        {
            InitializeComponent();
            queue = new CreateApptPriorityQueue();



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
                nameTextbox.Text = "";
                ageTextbox.Text = "";
                severityTextbox.Text = "";
                insuranceCheckbox.Checked = false;

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

            //AddDataToScheduleForm(queue);
            queue = new CreateApptPriorityQueue();

            this.Hide();

            scheduleForm.Show();
        }

        private void showQueueButton_Click(object sender, EventArgs e)
        {
            List<Patient> sortedQueue = SortQueue(queue);

            StringBuilder message = new StringBuilder();

            foreach (Patient patient in sortedQueue)
            {
                message.AppendLine(patient.ToString());
            }
            if (message.Length == 0) { 
                message.AppendLine("Queue is empty");
            }
            MessageBox.Show(message.ToString());



        }

        private List<Patient> SortQueue(CreateApptPriorityQueue queue)
        {
            List<Patient> patients = [.. queue];


            patients.Sort((x, y) => x.Priority.CompareTo(y.Priority)); 

            return patients;
        }

        /* private void AddDataToScheduleForm(CreateApptPriorityQueue newData)
         {
             if (scheduleForm != null && !scheduleForm.IsDisposed)
             {
                 scheduleForm.UpdateSchedule(newData);
                 queue = new CreateApptPriorityQueue();
             }
         }*/
    }
}
