namespace DoctorsAptApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new("Jefferey Heffrey", 85, 10);
            Patient patient1 = new("Richard", 83, 7, true);
            Patient patient2 = new("John", 25, 7);
            Patient patient3 = new("Homer", 43, 3);
            
            CreateApptPriorityQueue apptQueue = new();
            apptQueue.AddPatient(patient);
            apptQueue.AddPatient(patient1);
            apptQueue.AddPatient(patient2);
            apptQueue.AddPatient(patient3);
            Appointment appointment = new(patient, DateTime.Now.AddDays(1));
            Appointment appointment1 = new(patient1, DateTime.Now.AddDays(1));
            Appointment appointment2 = new(patient2, DateTime.Now.AddDays(1));
            Appointment appointment3 = new(patient3, DateTime.Now.AddDays(1));
            Console.WriteLine(appointment.Patient.Priority);
            Console.WriteLine(appointment1.Patient.Priority);
            Console.WriteLine(appointment2.Patient.Priority);
            Console.WriteLine(appointment3.Patient.Priority);


            /*Console.WriteLine(Patient.CalculatePriority(patient));
            Console.WriteLine(Patient.CalculatePriority(patient1));
            Console.WriteLine(Patient.CalculatePriority(patient2));
            Console.WriteLine(Patient.CalculatePriority(patient3));*/

            Console.WriteLine(apptQueue.deQueue() );
            Console.WriteLine(apptQueue.deQueue());
            Console.WriteLine(apptQueue.deQueue());
            Console.WriteLine(apptQueue.deQueue());
        }
    }
}
