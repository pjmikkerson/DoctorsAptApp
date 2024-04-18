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
            count++;
        }

        public Patient Dequeue()
        {
            if (patients.Count == 0)
            {
                return null;
            }
            count--;
            return patients.Dequeue();
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
