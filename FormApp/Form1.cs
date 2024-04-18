using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorsAptApp;


namespace FormApp
{
    public partial class patientForm : Form
    {
        ScheduleLinkedList queue = new ScheduleLinkedList();
        public patientForm()
        {
            InitializeComponent();
            
            

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            int age = int.Parse(ageTextbox.Text);
            int severity = int.Parse(severityTextbox.Text);
            bool insurance = insuranceCheckbox.Checked;
            Patient patient = new Patient(name: name, age: age, severity: severity, insurance: insurance);
            string message = patient.ToString();
            
            MessageBox.Show(message);
        }
    }
}
