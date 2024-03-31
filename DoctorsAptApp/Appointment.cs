using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAptApp
{
    internal class Appointment
    {
        private Patient patient;
        private DateTime dateTime;


        public Appointment(Patient patient, DateTime dateTime)
        {
            this.patient = patient;
            this.dateTime = dateTime;
        }

        public Patient Patient
        {
            get => patient;
            set => patient = value;
        }
        public DateTime DateTime {
            get=> dateTime; 
            set => dateTime = value; }



        public override string ToString()
        {
            return $"{patient.Name} - {dateTime}";
        }

    }
}
