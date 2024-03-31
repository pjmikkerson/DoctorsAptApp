using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAptApp
{
    internal class  CreateApptPriorityQueue
    {
        private PriorityQueue<Patient, int> patients;
        private int count = 0;


        public CreateApptPriorityQueue()
        {
            patients = new PriorityQueue<Patient, int>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Enqueue(patient, (patient.Priority * -1));
        }

        public string deQueue() 
        {
            count++;
            return patients.Dequeue().ToString() + "\n"+ count;
        }
    }
}
