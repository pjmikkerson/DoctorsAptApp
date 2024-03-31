using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAptApp
{
    internal class ScheduleLinkedList
    {
        private LinkedList<Appointment> schedule;

        public void SchedulePatient(Patient patient)
        {
            if (patient.Severity >= 8)
            {
                LinkedListNode<Appointment> nextAppt = schedule.First;
                if (nextAppt != null && nextAppt.Value.Patient.Priority < patient.Priority)
                {
                    Appointment appointment = new Appointment(patient, nextAppt.Value.DateTime);
                    schedule.AddBefore(nextAppt, appointment);
                }
                else
                {

                }
            }
        }
    }
}
