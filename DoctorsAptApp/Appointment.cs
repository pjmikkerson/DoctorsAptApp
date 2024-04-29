using System.Reflection.Metadata.Ecma335;

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
        public DateTime Time {
            get=> dateTime; 
            set => dateTime = value; }



        public override string ToString()
        {
            if (patient != null)
            {
                return $"{patient.Name} - {dateTime}";
            }
            else
            {
                return $"{dateTime}";
            }
        }

    }
}
